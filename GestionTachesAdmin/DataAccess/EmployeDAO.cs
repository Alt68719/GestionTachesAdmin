using MySql.Data.MySqlClient;

namespace GestionTachesAdmin.DataAccess
{
    public class EmployeDAO
    {
        // Ajout du paramètre "motDePasse" dans la signature
        public static bool CreerEmploye(string matricule, string nom, string prenom, string poste, string motDePasse)
        {
            bool success = false;
            using (var connexion = ConnexionBD.GetConnection())
            {
                // Ajout de la colonne mot_de_passe et de son paramètre @motDePasse
                string requete = "INSERT INTO EMPLOYE(matricule, nom, prenom, poste, mot_de_passe) VALUES(@matricule, @nom, @prenom, @poste, @motDePasse)";

                using (var command = new MySqlCommand(requete, connexion))
                {
                    command.Parameters.AddWithValue("@matricule", matricule);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@poste", poste);
                    command.Parameters.AddWithValue("@motDePasse", motDePasse); 

                    connexion.Open();
                    int ligneaffectes = command.ExecuteNonQuery();
                    success = ligneaffectes > 0;
                }
            }
            return success;
        }
    }
}