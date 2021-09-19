using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConnectSQLServer;

namespace ConnectSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");
            SqlConnection conn = SQLConnector.GetDBConnection();

            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful!");
                Console.WriteLine(conn.ConnectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            conn?.Close();
            Console.Read();
        }
    }
}
