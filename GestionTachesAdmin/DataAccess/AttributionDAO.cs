using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GestionTachesAdmin.Models;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace GestionTachesAdmin.DataAccess
{
    public class AttributionDAO
    {
        public List<Employe> GetEmployes()
        {
            List<Employe> liste = new List<Employe>();

            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "SELECT matricule,nom,prenom,poste FROM EMPLOYE";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    connexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new Employe
                            {
                                Matricule = reader.GetString("matricule"),
                                nom = reader.GetString("nom"),
                                prenom = reader.GetString("prenom"),
                                poste = reader.GetString("poste"),

                            });
                        }

                    }
                }
            }
            return liste;

        }
        public List<Tache> GetTacheDispo()
        {
            List<Tache> liste = new List<Tache>();
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "SELECT id_tache,titre,statut FROM TACHE WHERE statut = 'À faire'";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    connexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new Tache
                            {
                                Idtache = reader.GetInt32("id_tache"),
                                titre = reader.GetString("titre"),
                                status = reader.GetString("statut"),

                            });
                        }
                    }
                }
            }
            return liste;
        }
        public bool AttribuerEtNotifier(string matricule, int idtache, string titreTache)
        {
            using (var connexion = ConnexionBD.GetConnection())
            {
                connexion.Open();
                using (var transaction = connexion.BeginTransaction())
                {
                    try
                    {
                        string reqAttr = "INSERT INTO ATTRIBUTION (matricule,id_tache) VALUES(@matricule,@id_tache)";
                        using (var cmdAttr = new MySqlCommand(reqAttr, connexion, transaction))
                        {
                            cmdAttr.Parameters.AddWithValue("@matricule", matricule);
                            cmdAttr.Parameters.AddWithValue("@id_tache", idtache);
                            cmdAttr.ExecuteNonQuery();

                        }
                        string reqNotif = "INSERT INTO NOTIFICATION (contenu,type,matricule,id_tache)" + " VALUES(@contenu,@type,@matricule,@id_tache)";
                        using (var cmdNotif = new MySqlCommand(reqNotif, connexion, transaction))
                        {
                            string message = $"Nouvelle tâche attribuée : {titreTache}";
                            cmdNotif.Parameters.AddWithValue("@contenu", message);
                            cmdNotif.Parameters.AddWithValue("@type", "Attribution");
                            cmdNotif.Parameters.AddWithValue("@matricule", matricule);
                            cmdNotif.Parameters.AddWithValue("@id_tache", idtache);
                            cmdNotif.ExecuteNonQuery();
                        }
                        string reqUpdate = "UPDATE TACHE SET statut='En cours' WHERE id_tache=@id_tache";
                        using (var cmdUpdate = new MySqlCommand(reqUpdate, connexion, transaction))
                        {
                            cmdUpdate.Parameters.AddWithValue("@id_tache", idtache);
                            cmdUpdate.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        internal bool AttribuerTache(string? matricule, int idtache)
        {
            throw new NotImplementedException();
        }
    }
}