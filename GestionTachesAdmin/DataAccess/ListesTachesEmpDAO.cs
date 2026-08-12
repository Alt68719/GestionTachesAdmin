using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using GestionTachesAdmin.Forms.Models;

namespace GestionTachesAdmin.DataAccess
{
    public class ListesTachesEmpDAO
    {
        public List<ListesTachesEmp> GetListesTachesParEmps(string matricule)
        {
            List<ListesTachesEmp> liste = new List<ListesTachesEmp>();

            string query = @"SELECT t.id_tache, t.titre, t.description, t.priorite, t.statut, t.date_limite FROM tache t INNER JOIN attribution a ON t.id_tache = a.id_tache WHERE a.matricule = @matricule";

            using (MySqlConnection conn = ConnexionBD.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule ?? string.Empty);
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new ListesTachesEmp
                            {
                                Idtache = Convert.ToInt32(reader["id_tache"]),
                                titre = reader["titre"] != DBNull.Value ? reader["titre"].ToString()! : string.Empty,
                                description = reader["description"] != DBNull.Value ? reader["description"].ToString()! : string.Empty,
                                priorite = reader["priorite"] != DBNull.Value ? reader["priorite"].ToString()! : string.Empty,
                                status = reader["statut"] != DBNull.Value ? reader["statut"].ToString()! : string.Empty,
                                date_limite = reader["date_limite"] != DBNull.Value ? Convert.ToDateTime(reader["date_limite"]) : DateTime.MinValue
                            });
                        }
                    }
                }
            }
            return liste;
        }

        public bool ChangerStatutTache(int idTache, string nouveauStatut)
        {
            string query = "UPDATE tache SET statut = @statut WHERE id_tache = @idTache";

            try
            {
                using (MySqlConnection conn = ConnexionBD.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@statut", nouveauStatut ?? "En cours");
                        cmd.Parameters.AddWithValue("@idTache", idTache);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erreur SQL lors du changement de statut : " + ex.Message);
                return false;
            }
        }
    }
}