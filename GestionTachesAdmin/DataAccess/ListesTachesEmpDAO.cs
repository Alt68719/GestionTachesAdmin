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
            List<ListesTachesEmp> listes = new List<ListesTachesEmp>();

            string query = @"SELECT t.id_tache, t.titre, t.description, t.priorite, t.date_limite, t.statut, a.date_attribution FROM tache t INNER JOIN attribution a ON t.id_tache = a.id_tache WHERE a.matricule = @matricule";

            using (MySqlConnection connexion = ConnexionBD.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", (matricule ?? string.Empty).Trim());

                    connexion.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string statutStr = reader["statut"] != DBNull.Value ? (reader["statut"].ToString() ?? string.Empty) : string.Empty;

                            ListesTachesEmp tache = new ListesTachesEmp
                            {
                                Id_tache = reader["id_tache"] != DBNull.Value ? Convert.ToInt32(reader["id_tache"]) : 0,
                                Titre_Tache = reader["titre"] != DBNull.Value ? (reader["titre"].ToString() ?? string.Empty) : string.Empty,
                                Priorite_Tache = reader["priorite"] != DBNull.Value ? (reader["priorite"].ToString() ?? string.Empty) : string.Empty,
                                Date_Lime_Tache = reader["date_limite"] != DBNull.Value ? Convert.ToDateTime(reader["date_limite"]) : DateTime.Now,
                                Statut_Tache = statutStr.Equals("Terminé", StringComparison.OrdinalIgnoreCase) || statutStr.Equals("1")
                            };

                            listes.Add(tache);
                        }
                    }
                }
            }
            return listes;
        }

        public bool ChangerStatutTache(int idTache, string nouveauStatut)
        {
            string query = "UPDATE tache SET statut = @statut WHERE id_tache = @id";

            using (MySqlConnection conn = ConnexionBD.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@statut", nouveauStatut ?? string.Empty);
                    cmd.Parameters.AddWithValue("@id", idTache);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}