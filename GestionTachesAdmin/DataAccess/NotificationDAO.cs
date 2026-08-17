using GestionTachesAdmin.Forms.Models;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestionTachesAdmin.DataAccess
{
    public class NotificationDAO
    {
        public List<Notification> GetNotifications(string matricule)
        {
            List<Notification> list = new List<Notification>();
            string query = @"SELECT contenu,id_notification ,date_envoi FROM notification WHERE matricule = @matricule ";

            using (MySqlConnection connection = ConnexionBD.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule ?? string.Empty);
                    connection.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Notification
                            {
                                Id_notification = Convert.ToInt32(reader["id_notification"]),
                                ContenuNot = reader["contenu"] != DBNull.Value ? reader["contenu"].ToString()! : string.Empty,
                                DateAnvoi= reader["date_envoi"] != DBNull.Value ? Convert.ToDateTime(reader["date_envoi"]) : DateTime.MinValue
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
