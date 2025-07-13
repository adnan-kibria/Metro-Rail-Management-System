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
    public partial class VIP_Passenger : Form
    {
        private string selectedVipId;
        public VIP_Passenger()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedVipId))
            {
                Recharge r = new Recharge(selectedVipId);
                r.Show();
            }
            else
            {
                MessageBox.Show("Please select a VIP first.");
            }
        }

        private void bVipAdd_Click(object sender, EventArgs e)
        {
            VIP_Register vr = new VIP_Register();
            vr.Show();
            this.Hide();
        }

        private void bVipPR_Click(object sender, EventArgs e)
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

        private void bVipPp_Click(object sender, EventArgs e)
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

        private void dGVvip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedVipId = dGVvip.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void GeneratePDF(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();
            document.Add(new Paragraph("Passenger Report"));
            document.Add(new Paragraph(" "));
            PdfPTable pdfTable = new PdfPTable(dGVvip.Columns.Count);
            foreach (DataGridViewColumn column in dGVvip.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dGVvip.Rows)
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
        private void bVipPrint_Click(object sender, EventArgs e)
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

        private void VIP_Passenger_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "SELECT * FROM VIP_Passenger";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dt = ds.Tables[0];
            dGVvip.AutoGenerateColumns = true;
            dGVvip.DataSource = dt;
            conn.Close();

        }

        private void bVipBack_Click(object sender, EventArgs e)
        {
            Admin_Panel ap = new Admin_Panel();
            ap.Show();
            this.Hide();
        }

        private void bVipout_Click(object sender, EventArgs e)
        {
            MRT mRT = new MRT();
            mRT.Show();
            this.Hide();
        }

        private void txtSVip_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtSVip_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Name like '%{0}%' OR Email like '%{0}%' OR Phone_No like '%{0}%' OR Date_Of_Birth like '%{0}%' OR Gender like '%{0}%' OR NID_No like '%{0}%' OR Address like '%{0}%' OR Balance like '%{0}%' OR Token like '%{0}%'", txtSVip.Text);
            dGVvip.DataSource = dv.ToTable();
        }

    }
}
