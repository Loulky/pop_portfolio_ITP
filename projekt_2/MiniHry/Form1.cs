using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniHry
{
    public partial class VybraniHryForm : Form
    {
        string info = "Zdroje ikon: www.flaticon.com\nZdroj terce: www.flaticon.com\n\nAutor: Lukáš Pop\n\nVerze: 1.0";

        public VybraniHryForm()
        {
            InitializeComponent();

        }

        private void ZkouskaReakceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new RychlostForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void aimButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new PostrehForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(info, "Informace o aplikace");
        }

    }
}
