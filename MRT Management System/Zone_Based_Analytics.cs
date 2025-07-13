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
    public partial class Zone_Based_Analytics : Form
    {
        public Zone_Based_Analytics()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sortz sortz = new Sortz();
            sortz.Show();
            sortz.rbSzLH.Checked = false;
            sortz.rbSzHL.Checked = false;
            this.Hide();
        }

        private void bZReport_Click(object sender, EventArgs e)
        {
            Reports r = new Reports();
            r.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Sales_Report";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            r.dGVTSR.AutoGenerateColumns = true;
            r.dGVTSR.DataSource = dt;
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
            PdfPTable pdfTable = new PdfPTable(dGVZBA.Columns.Count);
            foreach (DataGridViewColumn column in dGVZBA.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVZBA.Rows)
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
        private void bZPrint_Click(object sender, EventArgs e)
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

        private void Zone_Based_Analytics_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Zone_Analysis";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dt = ds.Tables[0];
            dGVZBA.AutoGenerateColumns = true;
            dGVZBA.DataSource = dt;
            conn.Close();

        }

        private void bZBack_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
            this.Hide();
        }

        private void bZout_Click(object sender, EventArgs e)
        {
            MRT mRT = new MRT();
            mRT.Show();
            this.Hide();
        }

        private void txtSZone_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSZone_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Station_Name like '%{0}%' OR Total_Ticket_Sold like '%{0}%'", txtSZone.Text);
            dGVZBA.DataSource = dv.ToTable();
        }

    }
}
