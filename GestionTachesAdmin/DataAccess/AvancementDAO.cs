using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GestionTachesAdmin.Models;
using GestionTachesAdmin.Forms.Models;

namespace GestionTachesAdmin.DataAccess
{
    public class AvancementDAO
    {
        public static List<Avancement> GetAvancement()
        {
            List<Avancement> liste = new List<Avancement>();
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = @"SELECT e.nom,e.prenom,t.titre,t.statut FROM ATTRIBUTION a INNER JOIN EMPLOYE e ON a.matricule=e.matricule "
                               + "INNER JOIN TACHE t ON a.id_tache = t.id_tache";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    connexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new Avancement
                            {
                                NomEmp = reader.GetString("nom"),
                                PrenomEmp = reader.GetString("prenom"),
                                TacheName = reader.GetString("titre"),
                                statut = reader.GetString("statut")
                            });
                        }
                    }
                }
            }
            return liste;

        }
    }
}