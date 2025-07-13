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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }
        public Recharge(string vipId)
        {
            InitializeComponent();
            lblIDS.Text = vipId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "UPDATE VIP_Passenger SET Balance=" +txtRecharge.Text + " WHERE VIP_ID=" + lblIDS.Text;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            VIP_Passenger vp = new VIP_Passenger();
            string query1 = "SELECT * FROM VIP_Passenger";
            using (SqlCommand cmd2 = new SqlCommand(query1, con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                vp.dGVvip.AutoGenerateColumns = true;
                vp.dGVvip.DataSource = dt;
                cmd2.ExecuteNonQuery();
            };
            con.Close();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Recharge_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
