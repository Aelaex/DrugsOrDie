using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    class PatientenbesuchListe
    {
        public static List<Patientenbesuch> getAllePatienten()
        {
            List<Patientenbesuch> patientenListe = new List<Patientenbesuch>();
            List<int> idListe = new List<int>();
            SQL.CustomDBDataReader dbReaderAllPatients = SQL.SQL_Connector.sendRequest("select idPatientenbesuch from patientenbesuch");

            while (dbReaderAllPatients.Read())
            {
                idListe.Add(dbReaderAllPatients.getInt("idPatientenbesuch"));
            }
            dbReaderAllPatients.Close();

            foreach (int id in idListe)
            {
                patientenListe.Add(Patientenbesuch.getPatientenbesuch(id));
            }

            return patientenListe;
        }
        public static Patient createPatient(string vorname, string nachname)
        {
            return new Patient(vorname, nachname);
        }
    }
}
