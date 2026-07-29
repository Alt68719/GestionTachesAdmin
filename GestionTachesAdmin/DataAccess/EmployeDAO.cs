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
        public bool CreerEmploye(Employe emp)
        {
            using (var connexion = ConnexionBD.GetConnection())
            {
                string requete = "INSERT INTO EMPLOYE(matricule,nom,prenom,poste)" + " VALUES(@matricule,@nom,@prenom,@poste)";


                using (var command = new MySqlCommand(requete, connexion))
                {
                    command.Parameters.AddWithValue("@matricule", emp.Matricule);
                    command.Parameters.AddWithValue("@nom", emp.nom);
                    command.Parameters.AddWithValue("@prenom", emp.prenom);
                    command.Parameters.AddWithValue("@poste", emp.poste);

                    connexion.Open();
                    int ligneaffectes = command.ExecuteNonQuery();
                    return ligneaffectes > 0;
                }
            }
        }
    }
}
