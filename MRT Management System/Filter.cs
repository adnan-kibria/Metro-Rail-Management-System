using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MRT_Management_System
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            ApplyFilter(reports);
            reports.Show();
            this.Hide();
        }

        public void ApplyFilter(Reports reports)
        {
            string filterColumn = string.Empty;
            string groupByClause = string.Empty;

            if (rbDay.Checked)
            {
                filterColumn = "Day";
                groupByClause = "Day, Month, Year";
            }
            else if (rbMonth.Checked)
            {
                filterColumn = "Month";
                groupByClause = "Month, Year";
            }
            else if (rbYear.Checked)
            {
                filterColumn = "Year";
                groupByClause = "Year";
            }

            if (string.IsNullOrEmpty(filterColumn))
            {
                MessageBox.Show("Please select a filter option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = $@"
                        SELECT 
                            {groupByClause}, 
                            SUM(Total_Revenue) AS Total_Revenue, 
                            SUM(Total_Passenger_Count) AS Total_Passenger_Count
                        FROM Sales_Report
                        GROUP BY {groupByClause}
                        ORDER BY {filterColumn}";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            rbDay.Checked = false;
            rbMonth.Checked = false;
            rbYear.Checked = false;

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
    }
}
