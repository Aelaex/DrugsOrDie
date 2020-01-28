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
            PatientL patien = new PatientL("", "");
            
            
        }

        private void buttonPatientenliste_Click(object sender, EventArgs e)
        {
            Patientenliste pliste = new Patientenliste();
            pliste.Show();
        }
    }
}
