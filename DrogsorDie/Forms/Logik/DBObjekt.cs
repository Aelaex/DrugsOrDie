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
            System.Data.Common.DbDataReader reader = SQL.SQL_Connector.sendRequest($"SELECT max({primaryKey}) FROM {sqlName}");
            reader.Read();
            int result = reader.GetInt32(0);
            reader.Close();
            return result + 1;
        }
    }
}
