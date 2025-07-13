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
    public partial class ExGP : Form
    {
        public ExGP()
        {
            InitializeComponent();
        }

        private void textBoxegp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxegp.Text != "")
            {
                lblegp.Visible = false;
            }
            else
            {
                lblegp.Visible = true;
            }
        }

        private void Exit_gate_pass_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            string enteredToken = textBoxegp.Text;

            if (string.IsNullOrWhiteSpace(enteredToken))
            {
                MessageBox.Show("Please enter a valid token.", "Error");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkTicketQuery = "SELECT Token FROM Probation_Passenger WHERE Token = @Token";
                    using (SqlCommand cmdToken = new SqlCommand(checkTicketQuery, conn))
                    {
                        cmdToken.Parameters.AddWithValue("@Token", enteredToken);
                        SqlDataReader reader = cmdToken.ExecuteReader();

                        if (reader.Read())
                        {
                            reader.Close();
                            string deleteProbationQuery = "DELETE FROM Probation_Passenger WHERE Token = @Token";
                            using (SqlCommand deleteProbationCmd = new SqlCommand(deleteProbationQuery, conn))
                            {
                                deleteProbationCmd.Parameters.AddWithValue("@Token", enteredToken);
                                deleteProbationCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Probation record successfully removed.", "Success");

                            pw pwForm = new pw();
                            pwForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid token. No matching record found.", "Error");
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error");
                }
            }
        }

    }
}
