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
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(txtupUser.Text ==""&&txtupPass.Text =="") lblWar.Visible = true;
            else lblWar.Visible = false;
            if (string.IsNullOrEmpty(txtupUser.Text) || string.IsNullOrEmpty(txtupPass.Text))
            {
                lblWar.Visible = true;
                return;
            }

            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM UserInfo WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtupUser.Text);
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            string updateQuery = "UPDATE UserInfo SET Password = @Password WHERE Username = @Username";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                            {
                                updateCmd.Parameters.AddWithValue("@Password", txtupPass.Text);
                                updateCmd.Parameters.AddWithValue("@Username", txtupUser.Text);
                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            login login = new login();
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            lblWar.Visible = true;
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"A database error occurred: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMetroRailMS_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Forget_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
