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

namespace MRT_Management_System
{
    public partial class Payment_interface : Form
    {
        public Payment_interface()
        {
            InitializeComponent();

            //txttotalticket.Text = Ride_interface.ttl;
            //txttotalcost.Text = Ride_interface.result1;
        }

        private void Payment_interface_Load(object sender, EventArgs e)
        {
            
       
        }

        private void txtinputamount_TextChanged(object sender, EventArgs e)
        {
            if (txtinputamount.Text != "")
            {
                lblinputamount.Visible = false;
            }
            else
            {
                lblinputamount.Visible = true;
            }

           
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (txtinputamount.Text == txttotalcost.Text)
            {
                MessageBox.Show("Payment Successful", "Payment");

                Pdf_interface pdf_Interface = new Pdf_interface();
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                string query = "SELECT TOP 1 * FROM Ticket ORDER BY T_ID DESC";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        pdf_Interface.dGVPDF.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ticket data: " + ex.Message, "Error");
                }

                this.Hide();
                pdf_Interface.Show();
            }
            else
            {
                MessageBox.Show("Invalid Amount Entered", "Payment");
            }

        }

        //private string GenerateRandomCode()
        public string GenerateRandomCode()
        {
            Random rnd = new Random();
            string letters = ((char)rnd.Next(65, 91)).ToString() + (char)rnd.Next(65, 91);
            string numbers = rnd.Next(10, 100).ToString("00");
            return letters + numbers;
        }


        private void txttotalcost_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
