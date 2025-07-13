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
    public partial class Sortz : Form
    {
        public Sortz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zone_Based_Analytics zba = new Zone_Based_Analytics();
            zba.Show();
            if (rbSzLH.Checked)
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Zone_Analysis ORDER BY Total_Ticket_Sold ASC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    zba.dGVZBA.DataSource = dt;
                }
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Zone_Analysis ORDER BY Total_Ticket_Sold DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    zba.dGVZBA.DataSource = dt;
                }
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            rbSzLH.Checked = false;
            rbSzHL.Checked = false;
            Zone_Based_Analytics zba = new Zone_Based_Analytics();
            zba.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Zone_ID, Station_Name, Total_Ticket_Sold FROM Zone_Analysis";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        DataTable dt = ds.Tables[0];

                        zba.dGVZBA.AutoGenerateColumns = true;
                        zba.dGVZBA.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Hide();
        }

        private void Sortz_Load(object sender, EventArgs e)
        {

        }
    }
}
