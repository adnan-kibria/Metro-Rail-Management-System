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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            if (rbSLH.Checked)
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM sales_report ORDER BY Total_Revenue ASC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    r.dGVTSR.DataSource = dt;
                }
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM sales_report ORDER BY Total_Revenue DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    r.dGVTSR.DataSource = dt;
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
            rbSLH.Checked = false;
            rbSHL.Checked = false;
            Reports reports = new Reports();
            reports.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT Sales_ID, Day, Month, Year, Total_Revenue, Total_Passenger_Count FROM Sales_Report";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        sda.Fill(ds);
                        DataTable dt = ds.Tables[0];

                        reports.dGVTSR.AutoGenerateColumns = true;
                        reports.dGVTSR.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Hide();
        }

        private void Sort_Load(object sender, EventArgs e)
        {

        }
    }
}
