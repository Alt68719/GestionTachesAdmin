using System;
using MySql.Data.MySqlClient;

namespace GestionTachesAdmin.DataAccess
{
    public class AuthDAO
    {
        public bool VerifierEmploye(string matricule, string motDePasse)
        {
            bool estValide = false;

            using (var connexion = ConnexionBD.GetConnection())
            {
                // On compte s'il y a un employé avec ce matricule ET ce mot de passe
                string req = "SELECT COUNT(*) FROM EMPLOYE WHERE matricule = @matricule AND mot_de_passe = @mdp";

                using (var cmd = new MySqlCommand(req, connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@mdp", motDePasse);

                    connexion.Open();

                    // ExecuteScalar retourne la première colonne de la première ligne
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        estValide = true;
                    }
                }
            }
            return estValide;
        }
    }
}