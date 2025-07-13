using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MRT_Management_System
{
    public partial class revenuetracking : Form
    {
        public revenuetracking()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }
        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dgvrevenue.Columns.Count);
            foreach (DataGridViewColumn column in dgvrevenue.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvrevenue.Rows)
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
        private void btnprint_Click(object sender, EventArgs e)
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
        private void revenuetracking_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Revenue";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            dgvrevenue.AutoGenerateColumns = true;
            dgvrevenue.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void txtsearchrevenue_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Total_Ticket_Sold like '%{0}%' OR Total_Ticket_Cost like '%{0}%' OR Date like '%{0}%'", txtsearchrevenue.Text);
            dgvrevenue.DataSource = dv.ToTable();
        }



        private void txtsearchrevenue_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchrevenue.Text != "")
            {
                lblsearch.Visible = false;
            }
            else
            {
                lblsearch.Visible = true;
            }
        }

        private void btnfaremanagement_Click(object sender, EventArgs e)
        {
            fare_management fare_Management = new fare_management();
            this.Hide();
            fare_Management.Show();
        }

        private void dgvrevenue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
