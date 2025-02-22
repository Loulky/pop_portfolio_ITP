using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniHry
{
    public partial class RychlostForm : Form
    {
        Random rand = new Random();
        double dobaCekani;
        double probihani = 0;
        //stopwatch
        Stopwatch odezva = new Stopwatch();
        public RychlostForm()
        {
            InitializeComponent();

            timer1.Enabled = false;
            cekaniLabel.Location = new Point(ClientSize.Width / 2 - cekaniLabel.Width / 2, ClientSize.Height / 2 - cekaniLabel.Height / 2);
            kliniProStartLabel.Location = new Point(ClientSize.Width / 2 - kliniProStartLabel.Width / 2, ClientSize.Height / 2 - kliniProStartLabel.Height / 2);
            mocBrzoLabel.Location = new Point(ClientSize.Width / 2 - mocBrzoLabel.Width / 2, ClientSize.Height / 2 - mocBrzoLabel.Height / 2);
        }

        private void ZkouskaRychlosti_ClientSizeChanged(object sender, EventArgs e)
        {
            cekaniLabel.Location = new Point(ClientSize.Width / 2 - cekaniLabel.Width / 2, ClientSize.Height / 2 - cekaniLabel.Height / 2);
            kliniProStartLabel.Location = new Point(ClientSize.Width / 2 - kliniProStartLabel.Width / 2, ClientSize.Height / 2 - kliniProStartLabel.Height / 2);
            mocBrzoLabel.Location = new Point(ClientSize.Width / 2 - mocBrzoLabel.Width / 2 , ClientSize.Height / 2 - mocBrzoLabel.Height / 2);
            menuButton.Location = new Point(ClientSize.Width - menuButton.Width - 12, 12);
        }

        private void ZkouskaRychlosti_Click(object sender, EventArgs e)
        {
            if (kliniProStartLabel.Visible)
            {
                kliniProStartLabel.Visible = false;
                cekaniLabel.Visible = true;
                dobaCekani = rand.Next(50, 200);
                probihani = 0;
                timer1.Enabled = true;
            }
            else if (cekaniLabel.Visible && this.BackColor != Color.Green)
            {
                cekaniLabel.Visible = false;
                mocBrzoLabel.Visible = true;
                this.BackColor = Color.Red;
                probihani = 0;
                timer1.Enabled = false;

            }
            else if (mocBrzoLabel.Visible || this.BackColor == Color.Green && odezvaLabel.Visible)
            {
                odezvaLabel.Visible = false;
                mocBrzoLabel.Visible = false;
                cekaniLabel.Visible = true;
                this.BackColor = SystemColors.Control;
                dobaCekani = rand.Next(50, 200);
                probihani = 0;
                timer1.Enabled = true;
            }

            if (this.BackColor == Color.Green && !odezvaLabel.Visible)
            {
                odezva.Stop();
                cekaniLabel.Visible = false;
                odezvaLabel.Text = "Tvoje odezva: " + odezva.Elapsed.TotalMilliseconds + " ms";
                odezvaLabel.Location = new Point(ClientSize.Width / 2 - odezvaLabel.Width / 2, ClientSize.Height / 2 - odezvaLabel.Height / 2);
                odezvaLabel.Visible = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (dobaCekani > probihani)
            {
                probihani++;
            }
            else if (dobaCekani == probihani)
            {
                odezva.Reset();
                this.BackColor = Color.Green;
                odezva.Start();
                probihani = 0;
                timer1.Enabled = false;
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new VybraniHryForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void mocBrzoLabel_Click(object sender, EventArgs e)
        {
            odezvaLabel.Visible = false;
            mocBrzoLabel.Visible = false;
            cekaniLabel.Visible = true;
            this.BackColor = SystemColors.Control;
            dobaCekani = rand.Next(50, 200);
            probihani = 0;
            timer1.Enabled = true;
        }

        private void cekaniLabel_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.Green)
            {
                cekaniLabel.Visible = false;
                mocBrzoLabel.Visible = true;
                this.BackColor = Color.Red;
                probihani = 0;
                timer1.Enabled = false;
            }
            else
            {
                odezva.Stop();
                cekaniLabel.Visible = false;
                odezvaLabel.Text = "Tvoje odezva: " + odezva.Elapsed.TotalMilliseconds + " ms";
                odezvaLabel.Location = new Point(ClientSize.Width / 2 - odezvaLabel.Width / 2, ClientSize.Height / 2 - odezvaLabel.Height / 2);
                odezvaLabel.Visible = true;
            }

        }

        private void odezvaLabel_Click(object sender, EventArgs e)
        {
            odezvaLabel.Visible = false;
            mocBrzoLabel.Visible = false;
            cekaniLabel.Visible = true;
            this.BackColor = SystemColors.Control;
            dobaCekani = rand.Next(50, 200);
            probihani = 0;
            timer1.Enabled = true;
        }
        
        private void kliniProStartLabel_Click(object sender, EventArgs e)
        {
            kliniProStartLabel.Visible = false;
            cekaniLabel.Visible = true;
            dobaCekani = rand.Next(50, 200);
            probihani = 0;
            timer1.Enabled = true;
        }

        private void infoOHreButton_Click(object sender, EventArgs e)
        {
            string infoOHre = "Po kliknuti na zacatku vyckej na podbarveni pozadi zelenou. " +
                "Po kliknuti se zelenym pozadim se zobrazi odezva mezi zobrazenim a tvym kliknutim. " +
                "Klikni znovu pro dalsi pokus.";
            MessageBox.Show(infoOHre, "Informace k minihre");
        }
    }
}
