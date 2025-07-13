using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MRT_Management_System
{
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bPVip_Click(object sender, EventArgs e)
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

        private void bPPp_Click(object sender, EventArgs e)
        {
            Probation_Passenger pp = new Probation_Passenger();
            pp.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Probation_Passenger";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            pp.dGVProP.AutoGenerateColumns = true;
            pp.dGVProP.DataSource = dt;
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
            PdfPTable pdfTable = new PdfPTable(dGVP.Columns.Count);
            foreach (DataGridViewColumn column in dGVP.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVP.Rows)
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
        private void bPPrint_Click(object sender, EventArgs e)
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

        private void Passenger_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT *FROM Passenger";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            dGVP.AutoGenerateColumns = true;
            dGVP.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();
        }
        



        private void bPBack_Click(object sender, EventArgs e)
        {
            Admin_Panel ap = new Admin_Panel();
            ap.Show();
            this.Hide();
        }

        private void bPout_Click(object sender, EventArgs e)
        {
            MRT m = new MRT();
            m.Show();
            this.Hide();
        }

        private void txtSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txtSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%' OR Email like '%{0}%' OR Phone_No like '%{0}%' OR Date_Of_Birth like '%{0}%' OR Gender like '%{0}%' OR NID_No like '%{0}%' OR Address like '%{0}%' OR Date_Of_Travel like '%{0}%'", txtSP.Text);
            dGVP.DataSource = dv.ToTable();
        }
    }
}
