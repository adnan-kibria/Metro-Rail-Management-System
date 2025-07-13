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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sort s = new Sort();
            s.Show();
            s.rbSLH.Checked = false;
            s.rbSHL.Checked = false;
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Filter f = new Filter();
            f.Show();
            f.rbDay.Checked = false;
            f.rbMonth.Checked = false;
            f.rbYear.Checked = false;
            this.Hide();
        }

        private void bRZone_Click(object sender, EventArgs e)
        {
            Zone_Based_Analytics zba = new Zone_Based_Analytics();
            zba.Show();
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM Zone_Analysis";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            DataTable dt = ds.Tables[0];
            zba.dGVZBA.AutoGenerateColumns = true;
            zba.dGVZBA.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            InsertDataIntoSalesReport();
            LoadSalesReportData();
        }
        private void InsertDataIntoSalesReport()
        {
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string insertQuery = @"
                    INSERT INTO Sales_Report (Day, Month, Year, Total_Passenger_Count)
                    SELECT 
                        DAY(Date_Of_Travel) AS Day,
                        MONTH(Date_Of_Travel) AS Month,
                        YEAR(Date_Of_Travel) AS Year,
                        COUNT(*) AS Total_Passenger_Count
                    FROM Passenger
                    GROUP BY 
                        DAY(Date_Of_Travel), 
                        MONTH(Date_Of_Travel), 
                        YEAR(Date_Of_Travel)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LoadSalesReportData()
        {
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Sales_Report";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dGVTSR.AutoGenerateColumns = true;
                    dGVTSR.DataSource = dt;
                }
            }
        }

        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dGVTSR.Columns.Count);
            foreach (DataGridViewColumn column in dGVTSR.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVTSR.Rows)
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
        private void bRPrint_Click(object sender, EventArgs e)
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

        private void Reports_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            // SqlConnection conn = new SqlConnection(ConnectionString);
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM Sales_Report";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            //DataTable dt = ds.Tables[0];
            dt = ds.Tables[0];
            dGVTSR.AutoGenerateColumns = true;
            dGVTSR.DataSource = dt;
            // cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void txtSReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Day like '%{0}%' OR Month like '%{0}%' OR Year like '%{0}%' OR Total_Revenue like '%{0}%' OR Total_Passenger_Count like '%{0}%'", txtSReport.Text);
            dGVTSR.DataSource = dv.ToTable();
        }



        private void bRBack_Click(object sender, EventArgs e)
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
            this.Hide();
        }

        private void bRout_Click(object sender, EventArgs e)
        {
            MRT mRT = new MRT();
            mRT.Show();
            this.Hide();
        }
    }
}
