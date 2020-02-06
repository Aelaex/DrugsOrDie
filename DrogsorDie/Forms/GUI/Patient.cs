using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrogsorDie.Forms.Logik;

namespace DrogsorDie.Forms.GUI
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            PatientL patient = new PatientL("", "");
            textBoxVorname.Text = patient.Vorname;
            textBoxNachname.Text = patient.Nachname;
            textBoxPLZ.Text = Convert.ToString( patient.Plz);
            textBoxStraße.Text = patient.Straße;
            textBoxTelefon.Text = patient.Telefon;
            textBoxGerburstag.Text = patient.Geburtstag.ToString("dd/MM/yyyy");
            textBoxGeschlecht.Text = patient.Geschlecht;
            

        }

        private void buttonPatientenliste_Click(object sender, EventArgs e)
        {
            Patientenliste pliste = new Patientenliste();
            pliste.Show();
            

        }

        private void buttonAllergien_Click(object sender, EventArgs e)
        {
            DateTime test = new DateTime(2010,12,12);
            textBoxWohnort.Text = test.ToString("dd/MM/yyyy");
        }
    }
}
