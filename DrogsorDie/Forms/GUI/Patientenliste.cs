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
    public partial class Patientenliste : Form
    {
        public Patientenliste()
        {
            InitializeComponent();
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            try
            {
                dataGridView1.Rows.Clear();
                List<Logik.Patient> test = Logik.PatientenListe.getAllePatienten();
                int i = 0;
                foreach (var testa in test)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[i].Cells[0].Value = test[i].Id;
                    dataGridView1.Rows[i].Cells[1].Value = test[i].Vorname;
                    dataGridView1.Rows[i].Cells[2].Value = test[i].Nachname;
                    i++;
                }
            }
            catch(Exception e){}
        }
      

            private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                Patient patientform = new Patient( Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                patientform.Show();
                
            }

            private void Patientenliste_FormClosed(object sender, FormClosedEventArgs e)
            {
               Application.Exit();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                Patienthinzufügen patienthinzufügen = new Patienthinzufügen();
                patienthinzufügen.Show();
                refreshDataGrid();
        }

        private void aktualisieren_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }
    }
}
