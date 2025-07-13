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
    public partial class VIP_Register : Form
    {
        public VIP_Register()
        {
            InitializeComponent();
        }

        private string GenerateRandomCode()
        {
            Random rnd = new Random();
            string letters = ((char)rnd.Next(65, 91)).ToString() + (char)rnd.Next(65, 91);
            string numbers = rnd.Next(10, 100).ToString("00");
            return letters + numbers;
        }
        private void bReg_Click(object sender, EventArgs e)
        {
            if(txtN.Text == "") lblNcant.Visible = true;
            else lblNcant.Visible = false;
            if (txtMail.Text == "") lblMailcant.Visible = true;
            else lblMailcant.Visible = false;
            if (txtPhn.Text == "") lblPhncant.Visible = true;
            else lblPhncant.Visible = false;
            if (txtNID.Text == "") lblNIDcant.Visible = true;
            else lblNIDcant.Visible = false;
            if(!rbMale.Checked && !rbFemale.Checked) lblGencant.Visible = true;
            else lblGencant.Visible = false;
            if (txtAdd.Text == "") lblAddcant.Visible = true;
            else lblAddcant.Visible = false;
            if (txtN.Text != "" && txtMail.Text != "" && txtPhn.Text != "" && (rbMale.Checked || rbFemale.Checked) && txtNID.Text != "" && txtAdd.Text != "")
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string randomcode = GenerateRandomCode();
                string gender;
                if (rbMale.Checked) gender = "Male";
                else gender = "Female";
                string query = "INSERT INTO VIP_Passenger(Name,Email,Phone_No,Date_Of_Birth,Gender,NID_No,Address,Token) VALUES('" + txtN.Text + "','" + txtMail.Text + "','" + txtPhn.Text + "','" + Convert.ToDateTime(dTP.Text) + "','" + gender + "','" + txtNID.Text + "','" + txtAdd.Text +"','"+randomcode+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                VIP_Passenger vp = new VIP_Passenger();
                vp.Show();
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
        }

        private void VIP_Register_Load(object sender, EventArgs e)
        {

        }
    }
}
