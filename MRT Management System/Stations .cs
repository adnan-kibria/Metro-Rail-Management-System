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
    public partial class Stations : Form
    {
        public Stations()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Admin_Panel ap = new Admin_Panel();
            ap.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MRT m = new MRT();
            m.Show();
            this.Hide();
        }
        SqlConnection conn;
        SqlDataAdapter adp;
        DataTable dt;

        private void Stations_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM StationDetails";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dt = ds.Tables[0];
            dGVS.AutoGenerateColumns = true;
            dGVS.DataSource = dt;
            conn.Close();

        }

        private void dGVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dGVS.Columns.Count);
            foreach (DataGridViewColumn column in dGVS.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVS.Rows)
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

        private void bPrint_Click(object sender, EventArgs e)
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

        private void textBoxSearchHere_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxSearchHere_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Station_Name like '%{0}%' OR Station_Location like '%{0}%' OR Status like '%{0}%'", textBoxSearchHere.Text);
            dGVS.DataSource = dv.ToTable();
        }

    }
}
