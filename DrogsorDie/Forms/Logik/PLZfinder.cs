using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;

namespace DrogsorDie.Forms.Logik
{
    public class PLZfinder
    {
        public struct Postleitzahl //Struct PLZ
        {
            public int PLZ;
            public string OrtMitZusatz;
            public string Bundesland;

            public Postleitzahl(int PLZ, string OrtMitZusatz, string Bundesland)
            {
                this.PLZ = PLZ;
                this.OrtMitZusatz = OrtMitZusatz;
                this.Bundesland = Bundesland;
            }
        }
        List<Postleitzahl> plz_liste = new List<Postleitzahl>();
        private void PLZ_einlesen()//PLZ aus daten bank einlesen
        {
            string executableLocation = Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location);
            string csvLocation = Path.Combine(executableLocation, "plz_de.csv");
            string[] zeilen = File.ReadAllLines(csvLocation, Encoding.GetEncoding("iso-8859-1"));
            foreach (string PLZ in zeilen.Skip(1))
            {
                if (PLZ == "")
                {
                    continue;
                }
                String[] data = PLZ.Split(';');
                Postleitzahl a = new Postleitzahl();
                a.PLZ = int.Parse(data[2]);
                a.OrtMitZusatz = data[0] + data[1];
                a.Bundesland = data[4];
                plz_liste.Add(new Postleitzahl(int.Parse(data[2]), data[0] + data[1], data[4]));
            }
        }
        public string Ortsgeber(string plz)
        {
            try
            {
                PLZ_einlesen();
                foreach (Postleitzahl Postleitzahl in plz_liste)
                {
                    if (Postleitzahl.PLZ == int.Parse(plz))
                    {
                        return Postleitzahl.OrtMitZusatz;
                    }
                }
                return "fehler";
            }
            catch (Exception e){ return null; }
        }
    }
}