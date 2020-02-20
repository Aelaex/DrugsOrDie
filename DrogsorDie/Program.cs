using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrogsorDie.Forms.GUI;
namespace DrogsorDie
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DrogsorDie.Forms.SQL.SQL_Connector.initializeDefaultLocalConnection();
            //DrogsorDie.Forms.SQL.SQL_Connector.sendRequest("SELECT * FROM patienten");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Patientenliste());
            DrogsorDie.Forms.Logik.Patient test = DrogsorDie.Forms.Logik.Patient.getPatient(0);
            test.save();
        }
    }
}
