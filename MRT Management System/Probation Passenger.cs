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
    public partial class Probation_Passenger : Form
    {
        public Probation_Passenger()
        {
            InitializeComponent();
        }

        private void bPpPr_Click(object sender, EventArgs e)
        {
            Passenger p = new Passenger();
            p.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Passenger";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            p.dGVP.AutoGenerateColumns = true;
            p.dGVP.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
        }

        private void bPpVip_Click(object sender, EventArgs e)
        {
            VIP_Passenger vp = new VIP_Passenger();
            vp.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM VIP_Passenger";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            vp.dGVvip.AutoGenerateColumns = true;
            vp.dGVvip.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
        }

        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dGVProP.Columns.Count);
            foreach (DataGridViewColumn column in dGVProP.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVProP.Rows)
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
        private void bPpPrint_Click(object sender, EventArgs e)
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
        SqlConnection conn;
        SqlDataAdapter adp;
        DataTable dt;

        private void Probation_Passenger_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Probation_Passenger";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            dGVProP.AutoGenerateColumns = true;
            dGVProP.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void bPpBack_Click(object sender, EventArgs e)
        {
            Admin_Panel ap = new Admin_Panel();
            ap.Show();
            this.Hide();
        }

        private void bPpout_Click(object sender, EventArgs e)
        {
            MRT m = new MRT();
            m.Show();
            this.Hide();
        }

        private void txtSPro_TextChanged(object sender, EventArgs e)
        {

        }
        /*private void txtSPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%' OR Email like '%{0}%' OR Phone_No like '%{0}%' OR Date_Of_Birth like '%{0}%' OR Gender like '%{0}%' OR NID_No like '%{0}%' OR Address like '%{0}%' OR Status like '%{0}%' OR Token like '%{0}%'", txtSPro.Text);
            dGVProP.DataSource = dv.ToTable();
        }*/

        private void bSPro_Click(object sender, EventArgs e)
        {

        }

        private void bPpEn_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "DELETE FROM Probation_Passenger WHERE Pro_ID = " + txtShow.Text;
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

        private void dGVProP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dGVProP.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(id);
                txtShow.Text = id;
            }
        }

        private void txtSPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%' OR Email like '%{0}%' OR Phone_No like '%{0}%' OR Date_Of_Birth like '%{0}%' OR Gender like '%{0}%' OR NID_No like '%{0}%' OR Address like '%{0}%' OR Status like '%{0}%' OR Token like '%{0}%'", txtSPro.Text);
            dGVProP.DataSource = dv.ToTable();

        }
    }
}
