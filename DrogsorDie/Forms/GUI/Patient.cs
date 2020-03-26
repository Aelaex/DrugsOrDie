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
        private Logik.Patient patient;
        public Patient(int _id)
        {
            InitializeComponent();
            PLZfinder plZfinder = new PLZfinder();
            dateTimePickerGerburtstag.Format = DateTimePickerFormat.Custom;
            dateTimePickernächster_Besuch.Format = DateTimePickerFormat.Custom;
           dateTimePickerGerburtstag.CustomFormat = "dd/MM/yyyy";
           dateTimePickernächster_Besuch.CustomFormat = "dd/MM/yyyy";
            id = _id;
            patient = Logik.Patient.getPatient(_id);
            textBoxVorname.Text = patient.Vorname;
            textBoxNachname.Text = patient.Nachname;
            textBoxPLZ.Text = Convert.ToString( patient.Plz);
            textBoxWohnort.Text = plZfinder.Ortsgeber(patient.Plz);
            textBoxStraße.Text = patient.Straße;
            textBoxTelefon.Text = patient.Telefon;
            dateTimePickerGerburtstag.Value = patient.Geburtstag;
            textBoxGeschlecht.Text = patient.Geschlecht;
            dateTimePickernächster_Besuch.Value = patient.NaechsterBesuch;
            textBoxLetzterbekanterstatus.Text = patient.LetzterBekannterStatus;
            textBoxPatienbesuche_gesamt.Text = Convert.ToString(patient.Patientenbesuche_gesamt);
            textBoxHausnummer.Text = patient.Hausnr;
            int i = 0;
           
                List<Logik.Patientenbesuch> bPatientenbesuches =
                    Logik.PatientenbesuchListe.getPatientenbesuche(patient);
                i = bPatientenbesuches.Count;
                i = 0;
                foreach (var bpatientenbesuch in bPatientenbesuches)
                {
                    textBoxLetzterbekanterstatus.Text = bPatientenbesuches[i].EinlieferungsStatus.ToString();
                    i++;
                }
                
           

            textBoxPatienbesuche_gesamt.Text = i.ToString();

        }

        private void buttonAllergien_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            patient.Vorname = textBoxVorname.Text;
            patient.Nachname = textBoxNachname.Text;
            patient.Plz = textBoxPLZ.Text;
            patient.Straße = textBoxStraße.Text;
            patient.Telefon = textBoxTelefon.Text;
            patient.Geburtstag = dateTimePickerGerburtstag.Value;
            patient.Geschlecht = textBoxGeschlecht.Text;
            patient.NaechsterBesuch = dateTimePickernächster_Besuch.Value;
            patient.LetzterBekannterStatus = textBoxLetzterbekanterstatus.Text;
            patient.save();
        }

        private void buttonPatientenbesuche_Click(object sender, EventArgs e)
        {
            PatientenbesuchListe pliste = new PatientenbesuchListe(patient);
            pliste.Show();
        }

        private void textBoxPLZ_TextChanged(object sender, EventArgs e)
        {
            PLZfinder plZfinder = new PLZfinder();
            if ("fehler" == plZfinder.Ortsgeber(textBoxPLZ.Text))
            {}
            else
            {
                textBoxWohnort.Text = plZfinder.Ortsgeber(textBoxPLZ.Text);
            }
            
        }
    }
}
