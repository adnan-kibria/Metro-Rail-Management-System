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
    public partial class DiffPassenger : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
        public DiffPassenger()
        {
            InitializeComponent();
        }
        private bool IsPhoneInProbation(string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string probationCheckQuery = "SELECT * FROM Probation_Passenger WHERE Phone_No = @PhoneNumber";
                    using (SqlCommand probationCheckCmd = new SqlCommand(probationCheckQuery, conn))
                    {
                        probationCheckCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        int count = (int)probationCheckCmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    return false;
                }
            }
        }

        private void bRP_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhn.Text;

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            if (IsPhoneInProbation(phoneNumber))
            {
                MessageBox.Show("Please contact admin.", "Error");
                pw pwForm = new pw();
                pwForm.Show();
                this.Hide();
            }
            else
            {
                Ride_interface ri = new Ride_interface();
                ri.Show();
                this.Hide();
            }
        }

        private void bVP_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhn.Text;

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            if (IsPhoneInProbation(phoneNumber))
            {
                MessageBox.Show("Please contact admin.", "Error");
                pw pwForm = new pw();
                pwForm.Show();
                this.Hide();
            }
            else
            {
                EnGP enGP = new EnGP();
                enGP.Show();
                this.Hide();
            }
        }

        private void txtPhn_TextChanged(object sender, EventArgs e)
        {
        }

        private void DiffPassenger_Load(object sender, EventArgs e)
        {

        }
    }
}
