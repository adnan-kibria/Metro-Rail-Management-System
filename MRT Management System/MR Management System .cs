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
    public partial class MRT : Form
    {
        public MRT()
        {
            InitializeComponent();
        }


        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void MRT_Load(object sender, EventArgs e)
        {

        }
    }
}
