using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_proj.forms
{
    public partial class mainDashboard : Form
    {
        public mainDashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();

            depo.Show();
            this.Hide();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            withDraw with = new withDraw();
            with.Show();
        }
    }
}
