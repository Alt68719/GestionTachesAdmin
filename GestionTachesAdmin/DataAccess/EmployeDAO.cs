using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Ocsp;
using System.Data;
using System.Reflection.Metadata.Ecma335;

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
        public DataTable ListerEmploye()
        {
            DataTable dt = new DataTable();
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "SELECT matricule AS 'Matricule', nom AS 'Nom', prenom as 'Prenom', poste AS 'Poste' FROM EMPLOYE";
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



        public bool SupprimerEmploye(string matricule)
        {
            bool success = false;
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "DELETE FROM EMPLOYE WHERE matricule=@matricule";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    connexion.Open();
                    int ligneaffectes = cmd.ExecuteNonQuery();
                    success = (ligneaffectes > 0);
                }
            }
            return success;
        }
        public bool ModifierEmploye(string matricule, string nom, string prenom, string poste, string motDePasse)
        {
            bool success = false;
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req;
                if (string.IsNullOrEmpty(motDePasse))
                {
                    req = "UPDATE EMPLOYE SET nom=@nom, prenom=@prenom, poste=@poste WHERE matricule=@matricule";
                }
                else
                {
                    req = "UPDATE EMPLOYE SET nom=@nom, prenom=@prenom, poste=@poste, mot_de_passe=@motDePasse WHERE matricule=@matricule";
                }

                using (var cmd = new MySqlCommand(req, connexion))
                {
                    cmd.Parameters.AddWithValue("@matricule", matricule);
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@poste", poste);
                    if (!string.IsNullOrEmpty(motDePasse))
                        cmd.Parameters.AddWithValue("@motDePasse", motDePasse);

                    connexion.Open();
                    int ligneaffectes = cmd.ExecuteNonQuery();
                    success = (ligneaffectes > 0);
                }
            }
            return success;
        }

    }
}