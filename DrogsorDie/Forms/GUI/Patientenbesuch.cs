using System;
using System.Windows.Forms;
using DrogsorDie.Forms.Logik;

namespace DrogsorDie.Forms.GUI
{
    public partial class Patientenbesuch : Form
    {
        private int IDbesuch;
        public Patientenbesuch(int idBesuch)
        {
            InitializeComponent();
            dateTimePickerEinliferungszeitpunk.Format = DateTimePickerFormat.Custom;
            dateTimePickerEinliferungszeitpunk.CustomFormat= "dd/MM/yyyy";
            IDbesuch = idBesuch;
            var patientenbesuch =  Logik.Patientenbesuch.getPatientenbesuch(idBesuch);
            dateTimePickerEinliferungszeitpunk.Value = patientenbesuch.EinlieferungsZeitpunkt;
            textBox1.Text = patientenbesuch.Id.ToString();
            richTextBox1.Text = patientenbesuch.GrundDesBesuches;
            textboxStatus.Text = patientenbesuch.EinlieferungsStatus;
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            var patientenbesuch = Logik.Patientenbesuch.getPatientenbesuch(IDbesuch);
            patientenbesuch.GrundDesBesuches = richTextBox1.Text;
            patientenbesuch.EinlieferungsStatus = textboxStatus.Text;
            patientenbesuch.EinlieferungsZeitpunkt = dateTimePickerEinliferungszeitpunk.Value;
            patientenbesuch.safe();
        }
    }
}