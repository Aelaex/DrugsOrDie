using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    class PatientenListe
    {
        public static List<Patient> getAllePatienten()
        {
            List<Patient> patientenListe = new List<Patient>();
            System.Data.Common.DbDataReader dbReaderAllPatients = SQL.SQL_Connector.sendRequest("SELECT idPatient FROM PATIENTEN");
            while (dbReaderAllPatients.Read())
            {
                patientenListe.Add(Patient.getPatient(dbReaderAllPatients.GetInt32(dbReaderAllPatients.GetOrdinal("idPatient"))));
            }
            return patientenListe;
        }
    }
}
