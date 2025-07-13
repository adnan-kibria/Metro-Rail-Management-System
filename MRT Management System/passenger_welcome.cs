using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRT_Management_System
{
    public partial class pw : Form
    {
        public pw()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passenger_welcome_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            ExGP egp = new ExGP();
            egp.Show();
            this.Hide();
        }

        private void btnride_Click(object sender, EventArgs e)
        {
            DiffPassenger dp = new DiffPassenger();
            dp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MRT mrt = new MRT();
            mrt.Show();
            this.Hide();
        }
    }
}
