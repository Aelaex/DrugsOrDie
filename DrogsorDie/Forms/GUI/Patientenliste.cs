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
            for (int i = 0 ; i < 12 ; i++) {
                dataGridView1.Rows[i].Cells[0].Value = "Text";
                dataGridView1.Rows.Add(i +1 );
            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
