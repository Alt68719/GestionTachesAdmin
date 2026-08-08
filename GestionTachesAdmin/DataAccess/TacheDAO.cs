using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GestionTachesAdmin.DataAccess
{
    public class TacheDAO
    {
        public bool AjouterTache(string titre, string description,string priorite, DateTime dateLimite)
        {
            bool success = false;

            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = @"INSERT INTO TACHE (titre, description,priorite, date_limite, statut, date_creation) 
                               VALUES (@titre, @description,@priorite, @date_limite, @statut, @date_creation)";

                using (var cmd = new MySqlCommand(req, connexion))
                {
                    cmd.Parameters.AddWithValue("@titre", titre);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@priorite",priorite);
                    cmd.Parameters.AddWithValue("@date_limite", dateLimite);
                    cmd.Parameters.AddWithValue("@statut", "À faire"); // Statut par défaut
                    cmd.Parameters.AddWithValue("@date_creation", DateTime.Now); // Date automatique

                    try
                    {
                        connexion.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        success = (rowsAffected > 0);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erreur d'insertion dans la base de données : " + ex.Message);
                    }
                }
            }
            return success;
        }

        public DataTable ListerTache()
        {
            DataTable dt = new DataTable();
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "SELECT id_tache AS 'ID', titre AS 'Titre', description AS 'Description', priorite AS 'Priorite', date_limite AS 'DateLimite', statut AS 'Statut' FROM TACHE ORDER BY date_creation";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    connexion.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public bool SupprimerTache(string idTache)
        {
            bool success = false;
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "DELETE FROM TACHE WHERE id_tache=@id_tache";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    cmd.Parameters.AddWithValue("@id_tache", idTache);
                    connexion.Open();
                    int ligneaffectes = cmd.ExecuteNonQuery();
                    success = (ligneaffectes > 0);
                }
            }
            return success;
        }
        public bool ModifierTache(int id, string titre, string description, DateTime date_creation, string priorite)
        {
            bool success = false;
            using (var connexion = ConnexionBD.GetConnection())
            {

                string req = "UPDATE TACHE SET titre=@titre, description=@description, date_limite=@date_creation, priorite=@priorite WHERE id_tache=@id_tache";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    cmd.Parameters.AddWithValue("@titre",titre );
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@date_creation", date_creation);
                    cmd.Parameters.AddWithValue("@priorite", priorite);
                   
                    cmd.Parameters.AddWithValue("@id_tache", id);

                    connexion.Open();
                    int ligneaffectes = cmd.ExecuteNonQuery();
                    success = (ligneaffectes > 0);
                }
            }
            return success;
        }
    }
}