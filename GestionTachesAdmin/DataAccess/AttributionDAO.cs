using GestionTachesAdmin.Forms.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GestionTachesAdmin.DataAccess
{
    public class AttributionDAO
    {
        public List<Employe> GetEmployes()
        {
            List<Employe> liste = new List<Employe>();

            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = "SELECT matricule, nom, prenom, poste FROM EMPLOYE";
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
                                Nom = reader.GetString("nom"),       
                                Prenom = reader.GetString("prenom"), 
                                Poste = reader.GetString("poste")    
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
                string req = "SELECT id_tache, titre, statut FROM TACHE WHERE statut = 'À faire'";
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
                                status = reader.GetString("statut")  
                            });
                        }
                    }
                }
            }
            return liste;
        }

        // TRANSACTION COMPLETE : Attribution + Notification + Historique + Statut
        public bool AttribuerEtNotifier(string matricule, int idtache, string titreTache)
        {
            using (var connexion = ConnexionBD.GetConnection())
            {
                connexion.Open();
                using (var transaction = connexion.BeginTransaction())
                {
                    try
                    {
                        // 1. Insertion dans ATTRIBUTION
                        string reqAttr = "INSERT INTO ATTRIBUTION (matricule, id_tache) VALUES (@matricule, @id_tache)";
                        using (var cmdAttr = new MySqlCommand(reqAttr, connexion, transaction))
                        {
                            cmdAttr.Parameters.AddWithValue("@matricule", matricule);
                            cmdAttr.Parameters.AddWithValue("@id_tache", idtache);
                            cmdAttr.ExecuteNonQuery();
                        }

                        // 2. Insertion automatique dans NOTIFICATION
                        string reqNotif = "INSERT INTO NOTIFICATION (contenu, type, matricule, id_tache) " +
                                          "VALUES (@contenu, @type, @matricule, @id_tache)";
                        using (var cmdNotif = new MySqlCommand(reqNotif, connexion, transaction))
                        {
                            string message = $"Nouvelle tâche attribuée : {titreTache}";
                            cmdNotif.Parameters.AddWithValue("@contenu", message);
                            cmdNotif.Parameters.AddWithValue("@type", "Attribution");
                            cmdNotif.Parameters.AddWithValue("@matricule", matricule);
                            cmdNotif.Parameters.AddWithValue("@id_tache", idtache);
                            cmdNotif.ExecuteNonQuery();
                        }

                        // 3. Enregistrement dans l'HISTORIQUE
                        string reqHist = "INSERT INTO HISTORIQUE (action_realisee, id_tache, matricule) " +
                                         "VALUES (@action, @id_tache, @matricule)";
                        using (var cmdHist = new MySqlCommand(reqHist, connexion, transaction))
                        {
                            string actionDetail = $"Attribution de la tâche '{titreTache}' à l'employé {matricule}";
                            cmdHist.Parameters.AddWithValue("@action", actionDetail);
                            cmdHist.Parameters.AddWithValue("@id_tache", idtache);
                            cmdHist.Parameters.AddWithValue("@matricule", matricule);
                            cmdHist.ExecuteNonQuery();
                        }

                        // 4. Mise à jour du statut de la TACHE
                        string reqUpdate = "UPDATE TACHE SET statut = 'En cours' WHERE id_tache = @id_tache";
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

        public List<HistoriqueItem> GetHistorique()
        {
            List<HistoriqueItem> liste = new List<HistoriqueItem>();
            using (var connexion = ConnexionBD.GetConnection())
            {
                string req = @"SELECT h.id_historique, h.action_realisee, h.date_action, CONCAT(e.nom,' ',e.prenom) AS nom_employe, t.titre AS 
                                titre_tache FROM HISTORIQUE h LEFT JOIN EMPLOYE e ON h.matricule=e.matricule LEFT JOIN TACHE t ON h.id_tache
                                 =t.id_tache ORDER BY h.date_action DESC";
                using (var cmd = new MySqlCommand(req, connexion))
                {
                    connexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            liste.Add(new HistoriqueItem
                            {
                                IdHistorique = reader.GetInt32("id_historique"),
                                actionRealisee = reader.GetString("action_realisee"), 
                                DateAction = reader.GetDateTime("date_action"),
                                Employe = reader.IsDBNull(reader.GetOrdinal("nom_employe")) ? "Inconnu" : reader.GetString("nom_employe"),
                                Tache = reader.IsDBNull(reader.GetOrdinal("titre_tache")) ? "Non spécifiée" : reader.GetString("titre_tache")
                            });
                        }
                    }
                }
            }
            return liste;
        }
    }
}