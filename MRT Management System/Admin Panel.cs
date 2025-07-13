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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MRT m = new MRT();
            m.Show();
            this.Hide();
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            access.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM UserInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            access.dGVA.AutoGenerateColumns = true;
            access.dGVA.DataSource = dt;
            con.Close();
            this.Hide();
        }

        private void buttonStations_Click(object sender, EventArgs e)
        {
            Stations stations = new Stations();
            stations.Show();
            
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM StationDetails";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            stations.dGVS.AutoGenerateColumns = true;
            stations.dGVS.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }

        private void buttonFare_Click(object sender, EventArgs e)
        {
            fare_management fare = new fare_management();
            fare.Show();
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Fare_management1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            fare.dataGridView1.AutoGenerateColumns = true;
            fare.dataGridView1.DataSource = dt;
            conn.Close();
            this.Hide();
        }

        private void buttonPassenger_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Passenger";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            passenger.dGVP.AutoGenerateColumns = true;
            passenger.dGVP.DataSource = dt;
            con.Close();
            this.Hide();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Sales_Report";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            reports.dGVTSR.AutoGenerateColumns = true;
            reports.dGVTSR.DataSource = dt;
            con.Close();
            this.Hide();
        }
    }
}
