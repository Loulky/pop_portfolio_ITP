using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Bouncing_Ball_2._0
{
    public partial class NastaveniForm : Form
    {
        string informace = "---Ikony---\njoystick: www.flaticon.com \nozubena kola: www.flaticon.com\n\n---Informace o Bouncing Ball---" +
            "\nVerze: 2.0.1\nTvurce: Lukáš Pop";
        string oznameni = "---V okne nastaveni hry---\n****** '(Z)' - bez vybrani se aplikuje tento bod" +
            "\n\n---V okne hrani---\n'Mezernik'/'klik na Pauza' - Start, Pauza";

        int rychMiceVX = 8;
        int rychMiceVY = 6;
        int rychlosthracu = 10;
        bool vymenaVlevo = true;
        bool vymenaVpravo = true;
        Random rnd = new Random();
        int hracVlevoBody = 2;
        int hracVpravoBody = 1;
        int bodyVyhra = 3;
        int oznaceno2 = 0;

        public NastaveniForm()
        {
            InitializeComponent();
            nastaveniLabel.Text = "Bouncing Ball 2.0\nNastaveni";
            nastaveniLabel.Location = new Point(ClientSize.Width / 2 - nastaveniLabel.Width / 2, 25);
            
            gameTime.Enabled = true;
        }

        private void UlOdejitLabel_Click(object sender, EventArgs e)
        {
            MojeTrida.Barevanast = barvaCheckedListBox.SelectedIndex; //NEMAZAT NADpromenne
            MojeTrida.BodyNaVyhru = bodyNaVyhruCheckedListBox.SelectedIndex;
            MojeTrida.RychlostHracu = rychlosthracuCheckedListBox.SelectedIndex;
            MojeTrida.RychlostMice = rychlostMiceCheckedListBox.SelectedIndex;
            MojeTrida.BarvyHracu = barvaHracuCheckedListBox.SelectedIndex;

            gameTime.Stop();
            this.Hide();
            var form2 = new BouncingBallForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void barvaCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oznaceno = barvaCheckedListBox.SelectedIndex;
            if (oznaceno == -1)
                return;
            for (int pozice = 0; pozice < barvaCheckedListBox.Items.Count; pozice++)
                barvaCheckedListBox.SetItemCheckState(pozice, CheckState.Unchecked);
            barvaCheckedListBox.SetItemCheckState(oznaceno, CheckState.Checked);
            //zmena barvy v ukazce
            if (oznaceno == 0){
                pozadiPiBox.BackColor = Color.WhiteSmoke;
                hracVlevoBodyLabel.BackColor = Color.WhiteSmoke;
                hracVpravoBodyLabel.BackColor = Color.WhiteSmoke;
                micPiBox.BackColor = Color.WhiteSmoke;
            }
            else if (oznaceno == 1){
                pozadiPiBox.BackColor = Color.FromArgb(86, 84, 140);
                hracVlevoBodyLabel.BackColor = Color.FromArgb(86, 84, 140);
                hracVpravoBodyLabel.BackColor = Color.FromArgb(86, 84, 140);
                micPiBox.BackColor = Color.FromArgb(86, 84, 140);
            }
            else if (oznaceno == 2){
                pozadiPiBox.BackColor = Color.FromArgb(16, 56, 101);
                hracVlevoBodyLabel.BackColor = Color.FromArgb(16, 56, 101);
                hracVpravoBodyLabel.BackColor = Color.FromArgb(16, 56, 101);
                micPiBox.BackColor = Color.FromArgb(16, 56, 101);
            }
        }

        private void bodyNaVyhruCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            oznaceno2 = bodyNaVyhruCheckedListBox.SelectedIndex;
            if (oznaceno2 == -1)
                return;
            for (int pozice2 = 0; pozice2 < bodyNaVyhruCheckedListBox.Items.Count; pozice2++)
                bodyNaVyhruCheckedListBox.SetItemCheckState(pozice2, CheckState.Unchecked);
            bodyNaVyhruCheckedListBox.SetItemCheckState(oznaceno2, CheckState.Checked);
            //zmena bodu v ukazce
            if (oznaceno2 == 0) { hracVlevoBodyLabel.Text = rnd.Next(2).ToString(); hracVpravoBodyLabel.Text = rnd.Next(1, 2).ToString(); bodyVyhra = 3; }
            else if (oznaceno2 == 1) { hracVlevoBodyLabel.Text = rnd.Next(1, 4).ToString(); hracVpravoBodyLabel.Text = rnd.Next(2, 4).ToString(); bodyVyhra = 5; }
            else if (oznaceno2 == 2) { hracVlevoBodyLabel.Text = rnd.Next(3, 9).ToString(); hracVpravoBodyLabel.Text = rnd.Next(5, 9).ToString(); bodyVyhra = 10; }
            else if (oznaceno2 == 3) { hracVlevoBodyLabel.Text = rnd.Next(5, 14).ToString(); hracVpravoBodyLabel.Text = rnd.Next(10, 14).ToString(); bodyVyhra = 15; }
        }

        private void rychlosthracuCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oznaceno3 = rychlosthracuCheckedListBox.SelectedIndex;
            if (oznaceno3 == -1)
                return;
            for (int pozice3 = 0; pozice3 < rychlosthracuCheckedListBox.Items.Count; pozice3++)
                rychlosthracuCheckedListBox.SetItemCheckState(pozice3, CheckState.Unchecked);
            rychlosthracuCheckedListBox.SetItemCheckState(oznaceno3, CheckState.Checked);

            if (oznaceno3 == 0) { rychlosthracu = 7; }
            else if (oznaceno3 == 1) { rychlosthracu = 10; }
            else if (oznaceno3 == 2) { rychlosthracu = 13; }
            else if (oznaceno3 == 3) { rychlosthracu = 25; }
        }

        private void rychlostMiceCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oznaceno4 = rychlostMiceCheckedListBox.SelectedIndex;
            if (oznaceno4 == -1)
                return;
            for (int pozice4 = 0; pozice4 < rychlostMiceCheckedListBox.Items.Count; pozice4++)
                rychlostMiceCheckedListBox.SetItemCheckState(pozice4, CheckState.Unchecked);
            rychlostMiceCheckedListBox.SetItemCheckState(oznaceno4, CheckState.Checked);

            micPiBox.Location = new Point(pozadiPiBox.Location.X + pozadiPiBox.Width / 2 - micPiBox.Width / 2, pozadiPiBox.Location.Y + pozadiPiBox.Height / 2 - micPiBox.Height / 2);
            if (oznaceno4 == 0) { rychMiceVX = rychMiceVX = 6; rychMiceVY = 4; }
            else if (oznaceno4 == 1) { rychMiceVX = 8; rychMiceVY = 5; }
            else if (oznaceno4 == 2) { rychMiceVX = 11; rychMiceVY = 9; }
            else if (oznaceno4 == 3) { rychMiceVX = 22; rychMiceVY = 18; }
        }

        private void barvaHracuCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oznaceno5 = barvaHracuCheckedListBox.SelectedIndex;
            if (oznaceno5 == -1)
                return;
            for (int pozice5 = 0; pozice5 < barvaHracuCheckedListBox.Items.Count; pozice5++)
                barvaHracuCheckedListBox.SetItemCheckState(pozice5, CheckState.Unchecked);
            barvaHracuCheckedListBox.SetItemCheckState(oznaceno5, CheckState.Checked);

            if (oznaceno5 == 0)
            {
                hracVlevoPiBox.BackColor = Color.Crimson;
                hracVlevoBodyLabel.ForeColor = Color.Crimson;
                hracVpravoPiBox.BackColor = Color.MediumBlue;
                hracVpravoBodyLabel.ForeColor = Color.MediumBlue;
            }
            else if (oznaceno5 == 1)
            {
                hracVlevoPiBox.BackColor = Color.FromArgb(229, 135, 176);
                hracVlevoBodyLabel.ForeColor = Color.FromArgb(229, 135, 176);
                hracVpravoPiBox.BackColor = Color.FromArgb(250, 226, 2);
                hracVpravoBodyLabel.ForeColor = Color.FromArgb(250, 226, 2);
            }
            else if (oznaceno5 == 2)
            {
                hracVlevoPiBox.BackColor = Color.FromArgb(81, 21, 95);
                hracVlevoBodyLabel.ForeColor = Color.FromArgb(81, 21, 95);
                hracVpravoPiBox.BackColor = Color.FromArgb(217, 83, 60);
                hracVpravoBodyLabel.ForeColor = Color.FromArgb(217, 83, 60);
            }
        }

        private void NastaveniForm_Shown(object sender, EventArgs e)
        {
            MessageBox.Show(oznameni, "Informace ke hre");
        }

        private void odkazyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(informace, "Odkazy k pouzitym ikonam");
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            micPiBox.Left -= rychMiceVX;
            micPiBox.Top -= rychMiceVY;
            //odrazeni v X a Y souradnicich + pricitani bodu
            if (micPiBox.Top < pozadiPiBox.Location.Y || micPiBox.Bottom > pozadiPiBox.Location.Y + pozadiPiBox.Height)
            {
                rychMiceVY = -rychMiceVY;
            }
            if (micPiBox.Left < pozadiPiBox.Location.X)
            {
                rychMiceVX = -rychMiceVX;
                hracVpravoBody = Convert.ToInt32(hracVpravoBodyLabel.Text) + 1;
                hracVpravoBodyLabel.Text = hracVpravoBody.ToString();
            }
            if (micPiBox.Right > pozadiPiBox.Location.X + pozadiPiBox.Width)
            {
                rychMiceVX = -rychMiceVX;
                hracVlevoBody = Convert.ToInt32(hracVlevoBodyLabel.Text) + 1;
                hracVlevoBodyLabel.Text = hracVlevoBody.ToString();
            }
            //konec hry
            if (hracVlevoBody == bodyVyhra || hracVpravoBody == bodyVyhra)
            {
                if (hracVlevoBody == bodyVyhra) { vyhraLabel.ForeColor = hracVlevoPiBox.BackColor; }
                if (hracVpravoBody == bodyVyhra) { vyhraLabel.ForeColor = hracVpravoPiBox.BackColor; }
                vyhraLabel.Visible = true;
                VyhraTimer.Start();
                
                if (oznaceno2 == 0) { hracVlevoBodyLabel.Text = rnd.Next(2).ToString(); hracVpravoBodyLabel.Text = rnd.Next(1, 2).ToString(); bodyVyhra = 3; }
                else if (oznaceno2 == 1) { hracVlevoBodyLabel.Text = rnd.Next(1, 4).ToString(); hracVpravoBodyLabel.Text = rnd.Next(2, 4).ToString(); bodyVyhra = 5; }
                else if (oznaceno2 == 2) { hracVlevoBodyLabel.Text = rnd.Next(3, 9).ToString(); hracVpravoBodyLabel.Text = rnd.Next(5, 9).ToString(); bodyVyhra = 10; }
                else if (oznaceno2 == 3) { hracVlevoBodyLabel.Text = rnd.Next(5, 14).ToString(); hracVpravoBodyLabel.Text = rnd.Next(10, 14).ToString(); bodyVyhra = 15; }

                hracVpravoBody = Convert.ToInt32(hracVpravoBodyLabel.Text);
                hracVpravoBodyLabel.Text = hracVpravoBody.ToString();

                hracVlevoBody = Convert.ToInt32(hracVlevoBodyLabel.Text);
                hracVlevoBodyLabel.Text = hracVlevoBody.ToString();
            }

            //odrazeni od hrace
            if (micPiBox.Bounds.IntersectsWith(hracVlevoPiBox.Bounds) || micPiBox.Bounds.IntersectsWith(hracVpravoPiBox.Bounds)) {
                rychMiceVX = -rychMiceVX;
            }
            //pohyb hrace vlevo
            if (hracVlevoPiBox.Top >= pozadiPiBox.Location.Y && vymenaVlevo)
            {
                hracVlevoPiBox.Top -= rychlosthracu;
                if (hracVlevoPiBox.Top == pozadiPiBox.Location.Y || hracVlevoPiBox.Top < pozadiPiBox.Location.Y) { vymenaVlevo = false; }
            }
            if (hracVlevoPiBox.Bottom <= pozadiPiBox.Location.Y + pozadiPiBox.Height && !vymenaVlevo)
            {
                hracVlevoPiBox.Top += rychlosthracu;
                if (hracVlevoPiBox.Bottom == pozadiPiBox.Location.Y + pozadiPiBox.Height || hracVlevoPiBox.Bottom > pozadiPiBox.Location.Y + pozadiPiBox.Height) { vymenaVlevo = true; }
            }
            //pohyb hrace vpravo
            if (hracVpravoPiBox.Top >= pozadiPiBox.Location.Y && vymenaVpravo)
            {
                hracVpravoPiBox.Top -= rychlosthracu;
                if (hracVpravoPiBox.Top == pozadiPiBox.Location.Y || hracVpravoPiBox.Top < pozadiPiBox.Location.Y) { vymenaVpravo = false; }
            }
            if (hracVpravoPiBox.Bottom <= pozadiPiBox.Location.Y + pozadiPiBox.Height && !vymenaVpravo)
            {
                hracVpravoPiBox.Top += rychlosthracu;
                if (hracVpravoPiBox.Bottom == pozadiPiBox.Location.Y + pozadiPiBox.Height || hracVpravoPiBox.Bottom > pozadiPiBox.Location.Y + pozadiPiBox.Height) { vymenaVpravo = true; }
            }

        }
        private void VyhraTimer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(300);
            vyhraLabel.Visible = false;
            VyhraTimer.Stop();
            //Thread.Sleep(3);
            //vyhraLabel.Visible = false;

        }
    }
}
