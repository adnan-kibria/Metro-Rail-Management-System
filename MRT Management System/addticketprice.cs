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
    public partial class addticketprice : Form
    {
        public addticketprice()
        {
            InitializeComponent();
        }

        private void txtfromstation_TextChanged(object sender, EventArgs e)
        {
            if (txtfromstation.Text !="")
            {
                lblfromstation.Visible = false;
            }
            else
            {
                lblfromstation.Visible = true;
            }
        }

        private void txttostation_TextChanged(object sender, EventArgs e)
        {
            if (txttostation.Text != "")
            {
                lbltostation.Visible = false;
            }
            else
            {
                lbltostation.Visible = true;
            }
        }

        private void txtenterprice_TextChanged(object sender, EventArgs e)
        {
            if (txtenterprice.Text != "")
            {
                lblticketprice.Visible = false;
            }
            else
            {
                lblticketprice.Visible = true;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            //string query = "insert into practice2 (Id, Name, Email) values ("+Convert.ToInt32(textBox1.Text) + ",'"+textBox2.Text + "','"+textBox3.Text + "')";
            string query = "insert into Fare_management1 ( From_Station, To_station, Ticket_Price) values ('" + txtfromstation.Text + "','" + txttostation.Text + "','" +Convert.ToInt32(txtenterprice.Text) + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            txtfromstation.Text = txttostation.Text = txtenterprice.Text = "";

            MessageBox.Show("Add Application","Add Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fare_management fare_Management = new fare_management();
            this.Hide();
            fare_Management.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            fare_management fare_Management = new fare_management();
            this.Hide();
            fare_Management.Show();
        }

        private void addticketprice_Load(object sender, EventArgs e)
        {

        }

        private void lblfromstation_Click(object sender, EventArgs e)
        {

        }
    }
}
