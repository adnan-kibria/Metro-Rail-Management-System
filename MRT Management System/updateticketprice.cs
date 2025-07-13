using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MRT_Management_System
{
    public partial class updateticketprice : Form
    {

       /* public static updateticketprice instance;
        public TextBox tb1;
        public TextBox tb2;*/

        public updateticketprice()
        {
            InitializeComponent();

            txtfromstationupdate.Text = fare_management.from;
            txttostationupdate.Text = fare_management.to;

           /* instance = this;

            tb1 = txtfromstationupdate;
            tb2 = txttostationupdate;*/
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateticketprice_Load(object sender, EventArgs e)
        {

        }

        private void txtfromstationupdate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pnladdticketprice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtenterpriceupdate_TextChanged(object sender, EventArgs e)
        {
            if (txtenterpriceupdate.Text != "")
            {
                lblupdateticketprice.Visible = false;
            }
            else
            {
                lblupdateticketprice.Visible = true;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            //string query = "update Fare_management set Ticket_Price='" + txtenterpriceupdate.Text + "' where From_Station=" + txtfromstationupdate.Text + "' and To_Station=" + Convert.ToString(txtfromstationupdate.Text);
            string query = "UPDATE Fare_management1 SET Ticket_Price='" + Convert.ToString(txtenterpriceupdate.Text) + "' WHERE From_Station='" + txtfromstationupdate.Text + "' AND To_Station='" + txttostationupdate.Text + "';";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Update Successful");
            fare_management faremanagement = new fare_management();
            this.Hide();
            faremanagement.Show();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            fare_management faremanagement = new fare_management();
            this.Hide();
            faremanagement.Show();
        }

        private void lblupdateticketprice_Click(object sender, EventArgs e)
        {

        }
    }
}
