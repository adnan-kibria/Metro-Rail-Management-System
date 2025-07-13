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
    public partial class Assign : Form
    {
        public Assign()
        {
            //InitializeComponent();
        }
        public Assign(string userID)
        {
            Access access = new Access();
            //InitializeComponent();
            access.txtShow.Text = userID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=Phase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "UPDATE UserInfo SET Role = @Role WHERE User_ID = @UserID";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@Role", txtBox.Text);
            cmd.Parameters.AddWithValue("@UserID", access.txtShow.Text);
            cmd.ExecuteNonQuery();

            string query1 = "SELECT * FROM UserInfo";
            using (SqlCommand cmd2 = new SqlCommand(query1, con))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                access.dGVA.AutoGenerateColumns = true;
                access.dGVA.DataSource = dt;
            }
            con.Close();
            this.Hide();
        }

        private void bAX_Click(object sender, EventArgs e)
        {
            Access access = new Access();
            access.Show();
            this.Hide();
        }

        private void Assign_Load(object sender, EventArgs e)
        {

        }
    }
}
