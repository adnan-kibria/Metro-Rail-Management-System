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
    public partial class Employee_Login_Interface : Form
    {
        public Employee_Login_Interface()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-R0TURQUO\SQLEXPRESS;Initial Catalog=""MR system"";Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the Forget Interface form
            Employee_Forget_Interface forget = new Employee_Forget_Interface();

            // Show the Emp Forget Interface form
            forget.Show();

            // Optionally hide the current form
            this.Hide();
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text ))
             {
                textBoxUsername.Focus();
                errorProvider1.SetError(this.textBoxUsername, "Please fill your name.");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Silver;
            }

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "New Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "New Password")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Silver;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string Username, Password;

            Username = textBoxUsername.Text;
            Password = textBoxPassword.Text;


            try
            {
            string querry ="SELECT * FROM EmpLogin WHERE Username='"+textBoxUsername.Text+"' AND Password='"+ textBoxPassword.Text+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(querry,con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);


                if(dataTable.Rows.Count>0)
                {
                    Username = textBoxUsername.Text;
                    Password = textBoxPassword.Text;

                 

                }
            }

            catch
            {
                MessageBox.Show("Error");
            }

            finally
            {
                con.Close();
            }


















            string connectionString = "Data Source=LAPTOP-R0TURQUO\\SQLEXPRESS;Initial Catalog=\"MR system\";Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM EmpLogin WHERE username=@username AND password=@password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful!");
                        this.Hide();  // Hide login form
                        Admin_Panel adminPanel = new Admin_Panel();
                        adminPanel.Show(); // Open Admin Panel
                    }
                    else
                    {
                        MessageBox.Show("Username and Password are incorrect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
