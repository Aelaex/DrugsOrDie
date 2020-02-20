using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    class DBObjekt
    {

        protected static int getNextID(string sqlName, string primaryKey)
        {
            SQL.CustomDBDataReader customDBReader = SQL.SQL_Connector.sendRequest($"SELECT max({primaryKey}) FROM {sqlName}");
            customDBReader.Read();
            int result = customDBReader.reader.GetInt32(0);
            customDBReader.Close();
            return result + 1;
        }
    }
}