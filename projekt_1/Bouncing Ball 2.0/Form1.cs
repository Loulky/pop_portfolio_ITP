using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bouncing_Ball_2._0
{
    public partial class BouncingBallForm : Form
    {
        bool hracVlevoUP = false;
        bool hracVlevoDOWN = false;
        bool hracVpravoUP = false;
        bool hracVpravoDOWN = false;
        int rychMiceVX = 8;
        int rychMiceVY = 6;
        int hracVlevoBody = 0;
        int hracVpravoBody = 0;
        int bodyVyhra = 3;
        int rychlostHracu = 7;

        public BouncingBallForm()
        {
            InitializeComponent();
            gameTime.Stop();
        }

        private void BouncingBallForm_Load(object sender, EventArgs e)
        {
            //barva pozadi
            if (MojeTrida.Barevanast == 0)
            {
                this.BackColor = Color.WhiteSmoke;
            }
            else if (MojeTrida.Barevanast == 1){ this.BackColor = Color.FromArgb(86, 84, 140); }
            else if(MojeTrida.Barevanast == 2 ) { 
                this.BackColor = Color.FromArgb(16, 56, 101);
                pauzaLabel.ForeColor = Color.White;
                hracVlevoBodyLabel.ForeColor = Color.White;
                hracVpravoBodyLabel.ForeColor = Color.White;
            }
            //body na vyhru
            if (MojeTrida.BodyNaVyhru == 0) { bodyVyhra = 3; }
            else if (MojeTrida.BodyNaVyhru == 1) { bodyVyhra = 5; }
            else if (MojeTrida.BodyNaVyhru == 2) { bodyVyhra = 10; }
            else if (MojeTrida.BodyNaVyhru == 3) { bodyVyhra = 15; }
            //rychlost hracu
            if (MojeTrida.RychlostHracu == 0) { rychlostHracu = 7; }
            else if (MojeTrida.RychlostHracu == 1) { rychlostHracu = 10; }
            else if (MojeTrida.RychlostHracu == 2) { rychlostHracu = 13; }
            else if (MojeTrida.RychlostHracu == 3) { rychlostHracu = 25;}
            //rychlost mice
            if (MojeTrida.RychlostMice == 0) { rychMiceVX = 6; rychMiceVY = 4; }
            else if (MojeTrida.RychlostMice == 1) { rychMiceVX = 8; rychMiceVY = 5; }
            else if (MojeTrida.RychlostMice == 2) { rychMiceVX = 11; rychMiceVY = 9; }
            else if (MojeTrida.RychlostMice == 3) { rychMiceVX = 22; rychMiceVY = 18; }
            //barvy hracu
            if (MojeTrida.BarvyHracu == 0){
                hracVlevo.BackColor = Color.Crimson;
                hracVlevoBodyLabel.ForeColor = Color.Crimson;
                hracVlevoVyhraLabel.ForeColor = Color.Crimson;
                hracVpravo.BackColor = Color.MediumBlue;
                hracVpravoBodyLabel.ForeColor = Color.MediumBlue;
                hracVpravoVyhraLabel.ForeColor = Color.MediumBlue;
            }
            else if (MojeTrida.BarvyHracu == 1){
                hracVlevo.BackColor = Color.FromArgb(229, 135, 176);
                hracVlevoBodyLabel.ForeColor = Color.FromArgb(229, 135, 176);
                hracVlevoVyhraLabel.ForeColor = Color.FromArgb(229, 135, 176);
                hracVpravo.BackColor = Color.FromArgb(250, 226, 2);
                hracVpravoBodyLabel.ForeColor = Color.FromArgb(250, 226, 2);
                hracVpravoVyhraLabel.ForeColor = Color.FromArgb(250, 226, 2);
            }
            else if (MojeTrida.BarvyHracu == 2){
                hracVlevo.BackColor = Color.FromArgb(81, 21, 95);
                hracVlevoBodyLabel.ForeColor = Color.FromArgb(81, 21, 95);
                hracVlevoVyhraLabel.ForeColor = Color.FromArgb(81, 21, 95);
                hracVpravo.BackColor = Color.FromArgb(217, 83, 60);
                hracVpravoBodyLabel.ForeColor = Color.FromArgb(217, 83, 60);
                hracVpravoVyhraLabel.ForeColor = Color.FromArgb(217, 83, 60);
            }

        }

        private void doNastaveniButton_Click(object sender, EventArgs e)
        {
            DialogResult prejitdonastaveni = MessageBox.Show("Prejitim do nastaveni se hra restartuje", "Do nastaveni hry", MessageBoxButtons.OKCancel);
            if (prejitdonastaveni == DialogResult.OK)
            {
                this.Hide();
                var formnastaveni = new NastaveniForm();
                formnastaveni.Closed += (s, args) => this.Close();
                formnastaveni.Show();
            }
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            hracVlevoBodyLabel.Text = "" + hracVlevoBody;
            hracVpravoBodyLabel.Text = "" + hracVpravoBody;

            mic.Left -= rychMiceVX;
            mic.Top -= rychMiceVY;
            //vyhra label
            if (hracVlevoBody == bodyVyhra) { hracVlevoVyhraLabel.Visible = true; }
            if (hracVpravoBody == bodyVyhra) { hracVpravoVyhraLabel.Visible = true; }
            //vyhra
            if (hracVlevoBody == bodyVyhra || hracVpravoBody == bodyVyhra)
            {
                gameTime.Stop();
                hracVlevoBody = 0;
                hracVpravoBody = 0;
                mic.Location = new Point((ClientSize.Width / 2) - (mic.Width / 2), ClientSize.Height / 2 - mic.Height / 2);
                hracVlevo.Location = new Point(12, ClientSize.Height / 2 - hracVlevo.Height / 2);
                hracVpravo.Location = new Point(ClientSize.Width - 12 - hracVpravo.Width, ClientSize.Height / 2 - hracVpravo.Height / 2);
                pauzaLabel.Visible = true;
                doNastaveniButton.Visible = true;
                doNastaveniButton.Enabled = true;
                konecButton.Visible = true;
                konecButton.Enabled = true;
            }
            //pricitani bodu
            if (mic.Left < 0)
            {
                hracVpravoBody++;
                rychMiceVX = -rychMiceVX;
            }
            if (mic.Right > ClientSize.Width)
            {
                hracVlevoBody++;
                rychMiceVX = -rychMiceVX;
            }
            //odrazeni mice od stropu a spodku
            if (mic.Top < 0 || mic.Bottom > ClientSize.Height)
            {
                rychMiceVY = -rychMiceVY;
            }
            //odrazeni mice od hracu
            if (mic.Bounds.IntersectsWith(hracVlevo.Bounds) || mic.Bounds.IntersectsWith(hracVpravo.Bounds))
            {
                rychMiceVX = -rychMiceVX;
            }
            //pohyb hrace vlevo
            if (hracVlevoUP && hracVlevo.Top > 0)
            {
                hracVlevo.Top -= rychlostHracu;
            }
            if (hracVlevoDOWN && hracVlevo.Bottom < ClientSize.Height)
            {
                hracVlevo.Top += rychlostHracu;
            }
            //pohyb hrace vpravo
            if (hracVpravoUP && hracVpravo.Top > 0)
            {
                hracVpravo.Top -= rychlostHracu;
            }
            if (hracVpravoDOWN && hracVpravo.Bottom < ClientSize.Height)
            {
                hracVpravo.Top += rychlostHracu;
            }
        }

        private void BouncingBallForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (gameTime.Enabled)
                {
                    gameTime.Stop();
                    pauzaLabel.Visible = true;
                    doNastaveniButton.Visible = true;
                    doNastaveniButton.Enabled = true;
                    konecButton.Visible = true;
                    konecButton.Enabled = true;
                }
                else
                {
                    gameTime.Start();
                    pauzaLabel.Visible = false;
                    doNastaveniButton.Visible = false;
                    doNastaveniButton.Enabled = false;
                    konecButton.Visible = false;
                    konecButton.Enabled = false;
                    hracVlevoVyhraLabel.Visible = false;
                    hracVpravoVyhraLabel.Visible = false;
                }
            }
            //pohyb hrace vlevo
            if (e.KeyCode == Keys.W)
            {
                hracVlevoUP = true;
            }
            if (e.KeyCode == Keys.S)
            {
                hracVlevoDOWN = true;
            }
            //pohyb hrace vpravo
            if (e.KeyCode == Keys.Up)
            {
                hracVpravoUP = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                hracVpravoDOWN = true;
            }
        }

        private void BouncingBallForm_KeyUp(object sender, KeyEventArgs e)
        {
            //pohyb hrace vlevo
            if (e.KeyCode == Keys.W)
            {
                hracVlevoUP = false;
            }
            if (e.KeyCode == Keys.S)
            {
                hracVlevoDOWN = false;
            }
            //pohyb hrace vpravo
            if (e.KeyCode == Keys.Up)
            {
                hracVpravoUP = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                hracVpravoDOWN = false;
            }
        }

        private void BouncingBallForm_ClientSizeChanged(object sender, EventArgs e)
        {
            hracVlevo.Location = new Point(12, (ClientSize.Height / 2) - (hracVlevo.Height / 2));
            hracVpravo.Location = new Point(ClientSize.Width - hracVpravo.Width - 12, (ClientSize.Height / 2) - (hracVpravo.Height / 2));
            doNastaveniButton.Location = new Point(ClientSize.Width / 2 - doNastaveniButton.Width / 2, 139);
            pauzaLabel.Location = new Point(ClientSize.Width / 2 - pauzaLabel.Width / 2, 59);
            mic.Location = new Point(ClientSize.Width / 2 - mic.Width / 2, ClientSize.Height / 2 - mic.Height / 2);
            hracVpravoBodyLabel.Location = new Point(ClientSize.Width - hracVpravoBodyLabel.Width - 60, 60);
            konecButton.Location = new Point(ClientSize.Width / 2 - konecButton.Width / 2, ClientSize.Height + konecButton.Height - 280);
            hracVlevoVyhraLabel.Location = new Point(165, ClientSize.Height / 2 - hracVlevoVyhraLabel.Height / 2);
            hracVpravoVyhraLabel.Location = new Point(ClientSize.Width - 165 - hracVpravoVyhraLabel.Width, ClientSize.Height / 2 - hracVpravoVyhraLabel.Height / 2);
        }

        private void pauzaLabel_Click(object sender, EventArgs e)
        {
            gameTime.Start();
            pauzaLabel.Visible = false;
            doNastaveniButton.Visible = false;
            doNastaveniButton.Enabled = false;
            konecButton.Visible = false;
            konecButton.Enabled = false;
            hracVlevoVyhraLabel.Visible = false;
            hracVpravoVyhraLabel.Visible = false;
        }

        private void konecButton_Click(object sender, EventArgs e)
        {
            DialogResult konechrani = MessageBox.Show("Opravdu chces vypnout aplikaci?", "Vypnuti aplikace", MessageBoxButtons.OKCancel);
            if (konechrani == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}