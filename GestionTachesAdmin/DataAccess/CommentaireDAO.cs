using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using GestionTachesAdmin.Forms;
using GestionTachesAdmin.Forms.Models;
using MySql.Data.MySqlClient;
namespace GestionTachesAdmin.DataAccess
{
    public class CommentaireDAO
    {
        public static List<Commentaire> GetCommentaire()
        {
            List<Commentaire> liste = new List<Commentaire>();
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = @"SELECT * FROM commentaire ORDER BY date_commentaire";

                using(var cmd=new MySqlCommand(req,connexion))
                {
                    connexion.Open();
                    using(var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Commentaire commentaire = new Commentaire();
                            commentaire.IdCommentaire = reader.GetInt32("id_commentaire");
                            commentaire.Contenu = reader.GetString("contenu");
                            commentaire.dateComment = reader.GetDateTime("date_commentaire");
                            commentaire.matriculeEmp = reader.GetString("matricule");
                            commentaire.idTache = reader.GetInt32("id_tache");
                            liste.Add(commentaire);
                        }
                    }
                }
            }
            return liste;
        }
    }
}
