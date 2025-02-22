using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniHry
{
    public partial class PostrehForm : Form
    {
        int pocetTerce = 30;
        Stopwatch odezva = new Stopwatch();
        Random rn = new Random();
        public PostrehForm()
        {
            InitializeComponent();

            prumernaOdezvaLabel.Location = new Point(ClientSize.Width / 2 - prumernaOdezvaLabel.Width / 2, 259);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VybraniHryForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void infoOMinihreButton_Click(object sender, EventArgs e)
        {
            string infoOMinihre = "Kliknutim na prvni terc zacnes. " +
                "Ukol je kliknout na dalsi terc co nejrychleji. " +
                "Po kliknuti na 30 tercu se zobrazi prumerny cas menzi kliknutim na terce. " +
                "Klini znovu pro dalsi pokus.";
            MessageBox.Show(infoOMinihre, "Informace k minihre");
        }

        private void tercPiBox_Click(object sender, EventArgs e)
        {
            if (pocetTerce == 30) { zacniLabel.Visible = false; odezva.Reset(); odezva.Start(); prumernaOdezvaLabel.Visible = false; }
            if (pocetTerce > 0)
            {
                pocetTerce--;
                pocetTerceLabel.Text = "" + pocetTerce;
                int tercPiBoX = rn.Next(0, ClientSize.Width - tercPiBox.Width);
                int tercPiBoY = rn.Next(infoOMinihreButton.Location.Y + infoOMinihreButton.Height + 20, ClientSize.Height - tercPiBox.Height);
                tercPiBox.Location = new Point(tercPiBoX, tercPiBoY);
                odezva.Start();
            }
            if (pocetTerce == 0)
            {
                odezva.Stop();
                prumernaOdezvaLabel.Text = "Tvoje prumerna odezva: " + Convert.ToInt32(odezva.Elapsed.TotalMilliseconds / 30) + " ms";
                prumernaOdezvaLabel.Visible = true;
                tercPiBox.Location = new Point(ClientSize.Width / 2 - tercPiBox.Width / 2, ClientSize.Height / 2 - tercPiBox.Height / 2);
                prumernaOdezvaLabel.Location = new Point(ClientSize.Width / 2 - prumernaOdezvaLabel.Width / 2, ClientSize.Height / 2 - tercPiBox.Height - prumernaOdezvaLabel.Height);
                pocetTerce = 30;
            }
        }
    }
}
