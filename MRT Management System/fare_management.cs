using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MRT_Management_System
{
    public partial class fare_management : Form
    {
        // public static fare_management instance;

        public static string from;
        public static string to;
        public fare_management()
        {
            InitializeComponent();
            //instance = this;
        }

        SqlConnection conn;
        SqlDataAdapter adp;
        DataTable dt;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
            this.Hide();
        }

        public void fare_management_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Fare_management1";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();
        }


       /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0)
             {
                txtfrom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtto.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               
             }

            
        }*/

        private void btnadd_Click(object sender, EventArgs e)
        {
         
        addticketprice addticketprice = new addticketprice();
            this.Hide();
            addticketprice.Show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            from = txtfrom.Text;
            to = txtto.Text;

            updateticketprice updateticketprice = new updateticketprice();
             this.Hide();
            updateticketprice.Show();

            
        }

        private void btnfaremanagement_Click(object sender, EventArgs e)
        {

        }

        public void dataGridView1_Click(object sender, EventArgs e)
        {
            /*updateticketprice updateticketprice = new updateticketprice();
            updateticketprice.txtfromstationupdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateticketprice.txttostationupdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateticketprice.ShowDialog();*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             //updateticketprice upgradeprice = new updateticketprice();
             if(e.RowIndex>=0)
             {
                 txtfrom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                 txtto.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
             }

           // updateticketprice updateticketprice = new updateticketprice();
            //updateticketprice.txttostationupdate.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           // updateticketprice.txttostationupdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("To_Station like '%{0}%' OR Ticket_Price like '%{0}%'", txtsearchfare.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchfare.Text != "")
            {
                lblsearch.Visible = false;
            }
            else
            {
                lblsearch.Visible = true;
            }
            if (dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("To_Station like '%{0}%' OR Ticket_Price like '%{0}%'", txtsearchfare.Text.Replace("'", "''"));
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void btnrevenuetracking_Click(object sender, EventArgs e)
        {
            revenuetracking revenuetracking = new revenuetracking();
            revenuetracking.Show();
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Ticket";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            revenuetracking.dgvrevenue.AutoGenerateColumns = true;
            revenuetracking.dgvrevenue.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();

            //revenuetracking revenuetracking = new revenuetracking();
            this.Hide();
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MRT mRT = new MRT();
            mRT.Show();
            this.Hide();
        }
        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value?.ToString());
                }
            }
            document.Add(pdfTable);
            document.Close();
            MessageBox.Show("PDF generated successfully!");
            Process.Start(filePath);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GeneratePDF(saveFileDialog.FileName);
                }
            }
        }
    }
}
