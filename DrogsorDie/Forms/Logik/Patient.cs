using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    class PatientL
    {
        private int ID;
        private int plz;
        private string straße;
        private string hausnr;
        private string nachname;
        private string vorname;
        private DateTime geburtstag;
        private string geschlecht;
        private string telefon;
        private DateTime naechsterBesuch;
        private string letzterBekannterStatus;

        public int Plz { get => plz; set => plz = value; }
        public string Straße { get => straße; set => straße = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public DateTime Geburtstag { get => geburtstag; set => geburtstag = value; }
        public string Geschlecht { get => geschlecht; set => geschlecht = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public DateTime NaechsterBesuch { get => naechsterBesuch; set => naechsterBesuch = value; }
        public string LetzterBekannterStatus { get => letzterBekannterStatus; set => letzterBekannterStatus = value; }
        public string Hausnr { get => hausnr; set => hausnr = value; }
        public List<Vorerkrankung> Vorerkrankungen { get => null;}
        public List<Allergie> Allergien { get => null; }
        public List<Patientenbesuch> Patientenbesuche { get => null; }
        public double Gesamtkosten { get => 0; }
        public double Patientenbesuche_gesamt { get => 0; }


        public static PatientL getPatient(int patientenID)
        {
            return null;
        }
        public PatientL(string norname, string nachname)
        {

        }
        
    }
}