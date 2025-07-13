using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace MRT_Management_System
{
    public partial class Admin_panel : Form
    {

       s public static Admin_panel instance;
        public Admin_panel()
        {
            InitializeComponent();
            intance = this;
        }

        private void btnapacc_Click(object sender, EventArgs e)
        {
            Access from = new Access();
            Form.Show();


        }

        private void btnapst_Click(object sender, EventArgs e)
        {
             Station from = new station();
            Form.Show();

        }

        private void btnapf_Click(object sender, EventArgs e)
        {
            fare from = new fare();
            Form.Show();

        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            passenger from = new passenger();
            Form.Show();

        }

        private void btnr_Click(object sender, EventArgs e)
        {
            reports from = new reports();
            Form.Show();

        }
    }
}
