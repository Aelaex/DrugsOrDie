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
        private int id;
        public Patient(int _id)
        {
            InitializeComponent();
            id = _id;
            Logik.Patient patient = Logik.Patient.getPatient(_id);
            textBoxVorname.Text = patient.Vorname;
            textBoxNachname.Text = patient.Nachname;
            textBoxPLZ.Text = Convert.ToString( patient.Plz);
            textBoxStraße.Text = patient.Straße;
            textBoxTelefon.Text = patient.Telefon;
            textBoxGerburstag.Text = patient.Geburtstag.ToString("dd/MM/yyyy");
            textBoxGeschlecht.Text = patient.Geschlecht;
            textBoxnächster_Besuch.Text = patient.NaechsterBesuch.ToString("dd/MM/yyyy");
            textBoxLetzterbekanterstatus.Text = patient.LetzterBekannterStatus;
            textBoxPatienbesuche_gesamt.Text = Convert.ToString(patient.Patientenbesuche_gesamt);
            textBoxHausnummer.Text = patient.Hausnr;

        }

        private void buttonPatientenliste_Click(object sender, EventArgs e)
        {
            Patientenliste pliste = new Patientenliste();
            pliste.Show();
        }

        private void buttonAllergien_Click(object sender, EventArgs e)
        {
            DateTime test = new DateTime(2010, 12, 12);
            textBoxWohnort.Text = test.ToString("dd/MM/yyyy");
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            Logik.Patient patient = Logik.Patient.getPatient(id);
            patient.Vorname = textBoxVorname.Text;
            patient.Nachname = textBoxNachname.Text;
            patient.Plz = textBoxPLZ.Text;
            patient.Straße = textBoxStraße.Text;
            patient.Telefon = textBoxTelefon.Text;
            patient.Geburtstag = Convert.ToDateTime(textBoxGerburstag.Text);
            patient.Geschlecht = textBoxGeschlecht.Text;
            patient.NaechsterBesuch = Convert.ToDateTime(textBoxnächster_Besuch.Text);
            patient.LetzterBekannterStatus = textBoxLetzterbekanterstatus.Text;
            patient.save();
        }

        private void buttonPatientenbesuche_Click(object sender, EventArgs e)
        {
            PatientenbesuchListe pliste = new PatientenbesuchListe();
            pliste.Show();
        }
    }
}
