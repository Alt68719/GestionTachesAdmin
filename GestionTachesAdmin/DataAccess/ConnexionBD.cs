using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionTachesAdmin.DataAccess
{
    public class ConnexionBD
    {
        private static readonly string connectionstring = "Server=localhost;Database=gestion_taches_employes;Uid=root;Pwd=Morajason2006;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionstring);
        }

    }
}
