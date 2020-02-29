using System.Collections.Generic;
using System.Windows.Forms;
using DrogsorDie.Forms.Logik;

namespace DrogsorDie.Forms.GUI
{
    public partial class PatientenbesuchListe : Form
    {
        public PatientenbesuchListe()
        {
            InitializeComponent();
            List<Logik.Patientenbesuch> bPatientenbesuches = Logik.PatientenbesuchListe.getAllePatienten();
            int i = 0;
            foreach (var bpatientenbesuch in bPatientenbesuches)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i].Cells[0].Value = bPatientenbesuches[i].Id ;
              //  dataGridView1.Rows[i].Cells[1].Value = bPatientenbesuches[i].EinlieferungsZeitpunkt;
                i++;
            }
        }
    }
}