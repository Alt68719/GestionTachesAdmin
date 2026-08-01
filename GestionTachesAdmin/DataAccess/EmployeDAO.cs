using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GestionTachesAdmin.Models;

namespace GestionTachesAdmin.DataAccess
{
    public class EmployeDAO
    {
        // Le mot-clé 'static' a été ajouté ici
        public static bool CreerEmploye(string matricule, string nom, string prenom, string poste)
        {
            bool success = false;
            using (var connexion = ConnexionBD.GetConnection())
            {
                string requete = "INSERT INTO EMPLOYE(matricule,nom,prenom,poste) VALUES(@matricule,@nom,@prenom,@poste)";

                using (var command = new MySqlCommand(requete, connexion))
                {
                    command.Parameters.AddWithValue("@matricule", matricule);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@poste", poste);

                    connexion.Open();
                    int ligneaffectes = command.ExecuteNonQuery();
                    success = ligneaffectes > 0;
                }
            }
            return success;
        }
    }
}