using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DrogsorDie.Forms.GUI
{
    public partial class Patienthinzufügen : Form
    {
        public Patienthinzufügen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int id = 0;
            Logik.PatientenListe.createPatient(textBoxVorname.Text, textBoxNachname.Text);
            
                List<Logik.Patient> test = Logik.PatientenListe.getAllePatienten();
                foreach (var testa in test)
                {
                    id = test[i].Id ;
                    i++;
                }
            
            
            Patient patientform = new Patient( id);
            patientform.Show();
            this.Hide();
        }
    }
}