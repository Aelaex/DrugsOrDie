using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
namespace DrogsorDie.Forms.SQL
{
    static class SQL_Connector
    {
        private static MySqlConnection mySqlConnection;
        public static CustomDBDataReader sendRequest(string statement)
        {
            if (mySqlConnection != null)
            {
                MySqlCommand cmd = mySqlConnection.CreateCommand();
                cmd.CommandText = statement;
                DbDataReader dbDataReader = cmd.ExecuteReader();
                if (dbDataReader.HasRows)
                {
                    return new CustomDBDataReader(dbDataReader);
                }
                else
                {
                    throw new Exception("no Values found");
                }
            }
            else
            {
                throw new Exception("sqlConnection not Initialized");
            }
        }
        public static void sendUpdate(string statement)
        {
            if (mySqlConnection != null)
            {
                MySqlCommand cmd = mySqlConnection.CreateCommand();
                cmd.CommandText = statement;
                cmd.ExecuteNonQuery();
            }
            else
            {
                throw new Exception("sqlConnection not Initialized");
            }
        }
        public static void initializeDefaultLocalConnection()
        {
            initializeDBConnection("localhost", 3306, "default_schema", "DBUser", "user");
        }
        public static void initializeDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            mySqlConnection = new MySqlConnection(connString);
            mySqlConnection.Open();
        }
    }
}