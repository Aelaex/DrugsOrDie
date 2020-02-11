using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    class Patient : DBObjekt
    {
        private int id;
        private string plz;
        private string straße;
        private string hausnr;
        private string nachname;
        private string vorname;
        private DateTime geburtstag;
        private string geschlecht;
        private string telefon;
        private DateTime naechsterBesuch;
        private string letzterBekannterStatus;
        
        public int Id { get => id; set => id = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Straße { get => straße; set => straße = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public DateTime Geburtstag { get => geburtstag; set => geburtstag = value; }
        public string Geschlecht { get => geschlecht; set => geschlecht = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public DateTime NaechsterBesuch { get => naechsterBesuch; set => naechsterBesuch = value; }
        public string LetzterBekannterStatus { get => letzterBekannterStatus; set => letzterBekannterStatus = value; }
        public string Hausnr { get => hausnr; set => hausnr = value; }
      //  public List<Vorerkrankung> Vorerkrankungen { get => null;}
      //  public List<Allergie> Allergien { get => null; }
      //  public List<Patientenbesuch> Patientenbesuche { get => null; }
        public double Gesamtkosten { get => 0; }
        public double Patientenbesuche_gesamt { get => 0; }
        public static Patient getPatient(int patientenID)
        {
            Patient patient = new Patient();

            System.Data.Common.DbDataReader dbDataReaderPatient= SQL.SQL_Connector.sendRequest("SELECT * FROM patienten WHERE idPatient = " + patientenID);
            dbDataReaderPatient.Read();
            patient.Id = dbDataReaderPatient.GetInt32(dbDataReaderPatient.GetOrdinal("idPatient"));
            patient.Plz = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("plz"));
            patient.Straße = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("strasse"));
            patient.Hausnr = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("hausnummer"));
            patient.Nachname = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("name"));
            patient.Vorname = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("vorname"));
            patient.Geburtstag = DateTime.Parse(dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("geburtstag")));
            patient.Geschlecht = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("geschlecht"));
            patient.Telefon = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("telefon"));
            patient.NaechsterBesuch = DateTime.Parse(dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("naechsterBesuch")));
            patient.LetzterBekannterStatus = dbDataReaderPatient.GetString(dbDataReaderPatient.GetOrdinal("letzterBekannterStatus"));
            dbDataReaderPatient.Close();
            return patient;
        }
        public Patient(string vorname, string nachname)
        {
            
        }
        private Patient()
        {
            
        }
        public void save()
        {
            SQL.SQL_Connector.sendUpdate($"UPDATE PATIENTEN SET `plz` = \"{Plz}\",`strasse` = \"{Straße}\",`hausnummer` = \"{Hausnr}\",`name` = \"{Nachname}\",`vorname` = \"{Vorname}\",`geburtstag` = \"{Geburtstag.ToString("yyyy-MM-dd")}\",`geschlecht` = \"{Geschlecht}\",`telefon` = \"{Telefon}\",`naechsterBesuch` = \"{NaechsterBesuch.ToString("yyyy-MM-dd hh:mm:ss")}\",`letzterBekannterStatus` = \"{LetzterBekannterStatus}\"");
        }
        private static int getNextID()
        {
            return getNextID("Patienten","idPatient");
        }
    }
}