using System;
using MySql.Data.MySqlClient;

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

        internal bool AjouterTache(string titre, string description, object priorite, DateTime dateLimite)
        {
            throw new NotImplementedException();
        }
    }
}