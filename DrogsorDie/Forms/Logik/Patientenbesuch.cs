using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrogsorDie.Forms.Logik
{
    class Patientenbesuch : DBObjekt
    {
        private int id;
        private int patientenId;
        private DateTime einlieferungsZeitpunkt;
        private string einlieferungsStatus;
        private string grundDesBesuches;
        private DateTime abreiseZeitpunkt;

        public int Id { get => id; set => id = value; }
        public int PatientenId { get => patientenId; set => patientenId = value; }
        public DateTime EinlieferungsZeitpunkt { get => einlieferungsZeitpunkt; set => einlieferungsZeitpunkt = value; }
        public string EinlieferungsStatus { get => einlieferungsStatus; set => einlieferungsStatus = value; }
        public string GrundDesBesuches { get => grundDesBesuches; set => grundDesBesuches = value; }
        public TimeSpan Dauer { get => (abreiseZeitpunkt - einlieferungsZeitpunkt); }
        //public List<Symptome> symptome { get => dauer; set => dauer = value; }
        //public List<Behandlung> behandlungen { get => dauer; set => dauer = value; }
        //public List<Material> materialListe { get => dauer; set => dauer = value; }
        //public double Kosten { get => dauer; set => dauer = value; }

        public static Patientenbesuch getPatientenbesuch(int patientenBesuchsID)
        {
            Patientenbesuch patientenbesuch = new Patientenbesuch();

            SQL.CustomDBDataReader reader = SQL.SQL_Connector.sendRequest("SELECT * FROM patientenbesuch WHERE idPatientenbesuch = " + patientenBesuchsID);
            reader.Read();

            patientenbesuch.Id = reader.getInt("idPatientenbesuch");
            patientenbesuch.PatientenId = reader.getInt("idPatient");
            patientenbesuch.EinlieferungsZeitpunkt = reader.getDateTime("einlieferungsZeitpunkt");
            patientenbesuch.EinlieferungsStatus = reader.getString("einlieferungsStatus");
            patientenbesuch.GrundDesBesuches = reader.getString("grundDesBesuches");
            patientenbesuch.abreiseZeitpunkt = reader.getDateTime("abreiseZeitpunkt");
            reader.Close();

            return patientenbesuch;
        }
        private Patientenbesuch() { }
        public Patientenbesuch(int patientenID,DateTime einlieferungszeitpunkt)
        {
            Id = getNextID();
            PatientenId = patientenID;
            EinlieferungsZeitpunkt = einlieferungszeitpunkt;
            SQL.SQL_Connector.sendUpdate($"INSERT INTO `patientenbesuch` (`idPatientenbesuch`, `idPatient`, `einlieferungsZeitpunkt`) " +
                $"VALUES(\"{Id}\",\"{PatientenId}\",\"{EinlieferungsZeitpunkt.ToString("yyyy-MM-dd hh:mm:ss")}\")");
            
        }
        private static int getNextID()
        {
            return getNextID("patientenbesuch", "idPatientenbesuch");
        }
        public void safe()
        {
            SQL.SQL_Connector.sendUpdate($"UPDATE patientenbesuch SET `idPatient` = \"{PatientenId}\",`einlieferungsZeitpunkt` = \"{EinlieferungsZeitpunkt.ToString("yyyy-MM-dd hh:mm:ss")}\",`einlieferungsStatus` = \"{EinlieferungsStatus}\",`grundDesBesuches` = \"{GrundDesBesuches}\",`abreiseZeitpunkt` = \"{abreiseZeitpunkt.ToString("yyyy-MM-dd hh:mm:ss")}\"");
        }
    }
}
