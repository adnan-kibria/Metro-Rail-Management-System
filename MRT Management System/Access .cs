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

namespace MRT_Management_System
{
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MRT mRT = new MRT();
            mRT.Show();
            this.Hide();
        }

        SqlConnection conn;
        SqlDataAdapter adp;
        DataTable dt;

        private void Access_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM UserInfo";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            dGVA.AutoGenerateColumns = true;
            dGVA.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();
        }
        /*private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%' OR Email like '%{0}%' OR Username like '%{0}%' OR Password like '%{0}%' OR Date_Of_Birth like '%{0}%' OR Gender like '%{0}%' OR NID_No like '%{0}%' OR Address like '%{0}%' OR Role like '%{0}%'", textBox1.Text);
            dGVA.DataSource = dv.ToTable();
        }*/



        private void dGVA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dGVA.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id);
                txtShow.Text = id;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM UserInfo WHERE User_ID = " + txtShow.Text;
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                txtShow.Text = "";
            }
            else
            {
                MessageBox.Show("Please selct a row first");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM UserInfo";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dGVA.AutoGenerateColumns = true;
            dGVA.DataSource = dt;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Name LIKE '%{0}%' OR Email LIKE '%{0}%'", textBox1.Text.Replace("'", "''"));
                dGVA.DataSource = dv.ToTable();
            }
        }
        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dGVA.Columns.Count);
            foreach (DataGridViewColumn column in dGVA.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVA.Rows)
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

        private void button2_Click(object sender, EventArgs e)
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
