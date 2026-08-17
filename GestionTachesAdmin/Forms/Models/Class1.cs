using GestionTachesAdmin.DataAccess;
using GestionTachesAdmin.Forms.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace GestionTachesAdmin.Forms.Dao
{
    public class RapportProductiviteDAO
    {
        private readonly string _connectionString;

        public RapportProductiviteDAO(string connectionString = "")
        {
            _connectionString = connectionString;
        }
        public List<RapportProductivite> GenererRapportGlobal()
        {
            var rapports = new List<RapportProductivite>();

            string sql = @"
                SELECT 
                    e.matricule AS Matricule,
                    CONCAT(e.nom, ' ', e.prenom) AS EmployeNom,
                    COUNT(a.id_tache) AS TachesAssignees,
                    IFNULL(SUM(CASE WHEN LOWER(t.statut) = 'terminé' THEN 1 ELSE 0 END), 0) AS TachesTerminees
                FROM employe e
                LEFT JOIN attribution a ON a.matricule = e.matricule
                LEFT JOIN tache t ON t.id_tache = a.id_tache
                GROUP BY e.matricule, e.nom, e.prenom
                ORDER BY e.nom";

            using (var connection = ConnexionBD.GetConnection())
            using (var cmd = new MySqlCommand(sql, connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rapports.Add(MapperRapport(reader));
                    }
                }
            }

            return rapports;
        }
        public RapportProductivite? GenererRapportParEmploye(string matricule)
        {
            string sql = @"
                SELECT 
                    e.matricule AS Matricule,
                    CONCAT(e.nom, ' ', e.prenom) AS EmployeNom,
                    COUNT(a.id_tache) AS TachesAssignees,
                    IFNULL(SUM(CASE WHEN LOWER(t.statut) = 'terminé' THEN 1 ELSE 0 END), 0) AS TachesTerminees
                FROM employe e
                LEFT JOIN attribution a ON a.matricule = e.matricule
                LEFT JOIN tache t ON t.id_tache = a.id_tache
                WHERE e.matricule = @Matricule
                GROUP BY e.matricule, e.nom, e.prenom";

            using (var connection = ConnexionBD.GetConnection())
            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Matricule", matricule);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        return MapperRapport(reader);
                }
            }

            return null;
        }
        private RapportProductivite MapperRapport(MySqlDataReader reader)
        {
            return new RapportProductivite
            {
                Matricule = reader["Matricule"].ToString() ?? string.Empty,
                EmployeNom = reader["EmployeNom"] != DBNull.Value ? reader["EmployeNom"].ToString()! : string.Empty,
                TachesAssignees = Convert.ToInt32(reader["TachesAssignees"]),
                TachesTerminees = Convert.ToInt32(reader["TachesTerminees"]),
                HeuresTravaillees = 0 
            };
        }
    }
}