using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g.stock.connexion
{
    internal class ClassConnexion
    {
    }

public class connexion
    {
        public static string connectionString = "Server=DESKTOP-CB1FV86\\SQLEXPRESS;Database=GESTION_DE_STOCK;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }

}
