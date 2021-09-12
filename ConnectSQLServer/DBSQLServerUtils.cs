using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConnectSQLServer
{
    class SQLConnector
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"desktop-dj58kih\SQLEXPRESS";

            string database = "gameMarket";
            string username = "UserMarket";
            string password = "UserGameMarketPassword";

            return GetDBConnection(datasource, database, username, password);
        }

        public static SqlConnection GetDBConnection(string datasource, string database,string username, string password)
        {
            //
            // Data Source=SERVER-NAME;Initial Catalog=DATABASE-NAME;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }


    }
}
