﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DrogsorDie.Forms.SQL
{
    class SQL_Connector
    {
        public static MySqlConnection getDefaultLocalConnection()
        {
            String connString = "Server=" + "localhost" + ";Database=" + "default_schema"
                + ";port=" + "3306" + ";User Id=" + "user" + ";password=" + "user";

            return new MySqlConnection(connString);
        }
        public static MySqlConnection
                 GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}