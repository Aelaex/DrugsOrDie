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
            List<int> idListe = new List<int>();
            SQL.CustomDBDataReader dbReaderAllPatients = SQL.SQL_Connector.sendRequest("SELECT idPatient FROM PATIENTEN");
            
            while (dbReaderAllPatients.Read())
            {
                idListe.Add(dbReaderAllPatients.getInt("idPatient"));
            }
            dbReaderAllPatients.Close();

            foreach(int id in idListe)
            {
                patientenListe.Add(Patient.getPatient(id));
            }

            return patientenListe;
        }
        public static Patient createPatient(string vorname, string nachname)
        {
            return new Patient(vorname, nachname);
        }
    }
}
