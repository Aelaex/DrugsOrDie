using System.Windows.Forms;
using DrogsorDie.Forms.Logik;

namespace DrogsorDie.Forms.GUI
{
    public partial class Patientenbesuch : Form
    {
        public Patientenbesuch(int idBesuch)
        {
            InitializeComponent();
            var patientenbesuch =  Logik.Patientenbesuch.getPatientenbesuch(idBesuch);
            textBox1.Text = patientenbesuch.Id.ToString();
            
           
            
        }
    }
}