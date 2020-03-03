using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    public class Patient : DBObjekt
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

            SQL.CustomDBDataReader reader= SQL.SQL_Connector.sendRequest("SELECT * FROM patienten WHERE idPatient = " + patientenID);
            reader.Read();
            patient.Id = reader.getInt("idPatient");
            patient.Plz = reader.getString("plz");
            patient.Straße = reader.getString("strasse");
            patient.Hausnr = reader.getString("hausnummer");
            patient.Nachname = reader.getString("name");
            patient.Vorname = reader.getString("vorname");
            patient.Geburtstag = reader.getDateTime("geburtstag");
            patient.Geschlecht = reader.getString("geschlecht");
            patient.Telefon = reader.getString("telefon");
            patient.NaechsterBesuch = reader.getDateTime("naechsterBesuch");
            patient.LetzterBekannterStatus = reader.getString("letzterBekannterStatus");
            reader.Close();
            return patient;
        }
        public Patient(string vorname, string nachname)
        {
            // Create new Patient auf Datenbank
            Vorname = vorname;
            Nachname = nachname;
            Id = getNextID();
            SQL.SQL_Connector.sendUpdate($"INSERT INTO `patienten` (`idPatient`, `name`, `vorname`) " +
                $"VALUES(\"{Id}\",\"{Vorname}\",\"{Nachname}\")");
        }
        private Patient()
        {
            //Dieser Konstruktor sollte nur intern verwendet werden, um neue Objekte aus einer Datenbankabfrage zu erstellen
        }
        public void save()
        {
            SQL.SQL_Connector.sendUpdate($"UPDATE PATIENTEN SET `plz` = \"{Plz}\",`strasse` = \"{Straße}\",`hausnummer` = \"{Hausnr}\",`name` = \"{Nachname}\",`vorname` = \"{Vorname}\",`geburtstag` = \"{Geburtstag.ToString("yyyy-MM-dd")}\",`geschlecht` = \"{Geschlecht}\",`telefon` = \"{Telefon}\",`naechsterBesuch` = \"{NaechsterBesuch.ToString("yyyy-MM-dd hh:mm:ss")}\",`letzterBekannterStatus` = \"{LetzterBekannterStatus}\" WHERE `idPatient` = \"{Id}\"");
        }
        private static int getNextID()
        {
            return getNextID("Patienten","idPatient");
        }
    }
}