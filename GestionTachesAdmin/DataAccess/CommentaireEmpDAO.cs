using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace GestionTachesAdmin.DataAccess
{
    public class CommentaireModel
    {
        public int IdCommentaire { get; set; }
        public string Contenu { get; set; } = string.Empty;
        public DateTime DateCommentaire { get; set; }
        public string Matricule { get; set; } = string.Empty;
        public int IdTache { get; set; }
    }

    public class CommentaireEmpDAO
    {
        private string connectionstring = "Server=localhost;Database=gestion_taches_employes;Uid=root;Pwd=DERALAZA;";

        public List<CommentaireModel> GetCommentairesParTache(int idTache)
        {
            List<CommentaireModel> liste = new List<CommentaireModel>();

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT id_commentaire, contenu, date_commentaire, matricule, id_tache FROM commentaire WHERE id_tache = @idTache ORDER BY date_commentaire ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idTache", idTache);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new CommentaireModel
                            {
                                IdCommentaire = Convert.ToInt32(reader["id_commentaire"]),
                                Contenu = reader["contenu"].ToString() ?? "",
                                DateCommentaire = Convert.ToDateTime(reader["date_commentaire"]),
                                Matricule = reader["matricule"].ToString() ?? "",
                                IdTache = Convert.ToInt32(reader["id_tache"])
                            });
                        }
                    }
                }
            }
            return liste;
        }

        public bool AjouterCommentaire(int idTache, string matricule, string contenu)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "INSERT INTO commentaire (contenu, date_commentaire, matricule, id_tache) VALUES (@contenu, NOW(), @matricule, @idTache)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@contenu", contenu);
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@idTache", idTache);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}