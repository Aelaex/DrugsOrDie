using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DrogsorDie.Forms.SQL
{
    class CustomDBDataReader
    {
        public DbDataReader reader;

        public CustomDBDataReader(DbDataReader dbDataReader)
        {
            reader = dbDataReader;
        }
        public bool Read()
        {
            return reader.Read();
        }
        public int getInt(string fieldname)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldname)))
            {
                return 0;
            }
            return reader.GetInt32(reader.GetOrdinal(fieldname));
        }
        public string getString(string fieldname)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldname)))
            {
                return "";
            }
            return reader.GetString(reader.GetOrdinal(fieldname));
        }
        public DateTime getDateTime(string fieldname)
        {
            if (reader.IsDBNull(reader.GetOrdinal(fieldname)))
            {
                return new DateTime(1900,1,1);
            }
            return reader.GetDateTime(reader.GetOrdinal(fieldname));
        }
        public void Close()
        {
            reader.Close();
        }
    }
}
