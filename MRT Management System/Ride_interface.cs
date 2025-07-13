using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MRT_Management_System
{
    public partial class Ride_interface : Form
    {
        private double result;
        private int tt;

        private const string ConnectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";

        public Ride_interface()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtnumber.Text;
            string randomCode = GenerateRandomCode();
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                 
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            
                         
                            string insertTicketQuery = "INSERT INTO Ticket (Phone_No,From_Station, To_Station, Total_Ticket, Unique_Token, Date, Total_Amount) " +
                                                        "VALUES (@PhoneNumber,@FromStation, @ToStation, @TotalTicket, @UniqueToken, @Date, @TotalAmount)";
                            using (SqlCommand cmdTicket = new SqlCommand(insertTicketQuery, conn, transaction))
                            {
                                cmdTicket.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                cmdTicket.Parameters.AddWithValue("@FromStation", cbfrom.Text);
                                cmdTicket.Parameters.AddWithValue("@ToStation", cbto.Text);
                                cmdTicket.Parameters.AddWithValue("@TotalTicket", tt);
                                cmdTicket.Parameters.AddWithValue("@UniqueToken", randomCode);
                                cmdTicket.Parameters.AddWithValue("@Date", dateStr);
                                cmdTicket.Parameters.AddWithValue("@TotalAmount", result);
                                

                                cmdTicket.ExecuteNonQuery();
                            }

                           
                    
                            string insertPassengerQuery = "INSERT INTO Passenger (Phone_No, Date_Of_Travel) VALUES (@PhoneNumber, @Date)";
                            using (SqlCommand cmdPassenger = new SqlCommand(insertPassengerQuery, conn, transaction))
                            {
                                cmdPassenger.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                cmdPassenger.Parameters.AddWithValue("@Date", dateStr);

                                cmdPassenger.ExecuteNonQuery();
                            }

                  
                            transaction.Commit();
                            MessageBox.Show("Data successfully inserted.");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error during insertion: " + ex.Message);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            ShowPaymentInterface();
        }

        private void ShowPaymentInterface()
        {
            Payment_interface payment_Interface = new Payment_interface();
            textBox1.Text = Convert.ToString(result);
            textBox2.Text = Convert.ToString(tt);
            payment_Interface.Show();
            payment_Interface.txttotalcost.Text = textBox1.Text;
            payment_Interface.txttotalticket.Text = textBox2.Text;
            this.Hide();
        }

        private string GenerateRandomCode()
        {
            Random rnd = new Random();
            string letters = ((char)rnd.Next(65, 91)).ToString() + (char)rnd.Next(65, 91);
            string numbers = rnd.Next(10, 100).ToString("00");
            return letters + numbers;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(1, 20);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(2, 40);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(3, 60);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(4, 80);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(5, 100);
        }

        private void HandleButtonClick(int ticketCount, double pricePerTicket)
        {
            tt = ticketCount;
            result = ticketCount * pricePerTicket;
            MessageBox.Show($"Total Cost: {result}");
        }
    }
}
