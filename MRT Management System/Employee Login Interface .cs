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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MRT_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Forgot f = new Forgot();
            f.Show();
            this.Hide();
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
           

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtPass.Text == "") lblWarning.Visible = true;
            else lblWarning.Visible = false;
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                lblWarning.Visible = true;
                return;
            }

            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Role FROM UserInfo WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPass.Text);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string role = result.ToString();
                            if (role == "admin")
                            {
                                Admin_Panel aP = new Admin_Panel();
                                aP.Show();
                                this.Hide();
                            }
                            else if (role == "employee")
                            {
                                pw pp = new pw();
                                pp.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            lblWarning.Visible = true;
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

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
