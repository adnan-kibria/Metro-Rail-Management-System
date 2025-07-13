using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRT_Management_System
{
    public partial class EnGP : Form
    {
        public EnGP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btngp_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-4I032T2\\SQLEXPRESS;Initial Catalog=\"Metro Rail Management System\";Integrated Security=True";
            string enteredToken = textBoxgp.Text;

            if (string.IsNullOrWhiteSpace(enteredToken))
            {
                MessageBox.Show("Please enter a valid token.", "Error");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string phoneNumber,token;
                    string checkTicketQuery = "SELECT * FROM Ticket WHERE Unique_Token = @Token";
                    using (SqlCommand cmdTicket = new SqlCommand(checkTicketQuery, conn))
                    {
                        cmdTicket.Parameters.AddWithValue("@Token", enteredToken);
                        SqlDataReader reader = cmdTicket.ExecuteReader();

                        if (reader.Read())
                        {
                            phoneNumber = reader["Phone_No"].ToString();
                            token = reader["Unique_Token"].ToString();
                            reader.Close();

                            
                            string insertProbationQuery = "INSERT INTO Probation_Passenger (Phone_No, Token) VALUES (@PhoneNumber, @Token)";
                            using (SqlCommand insertProbationCmd = new SqlCommand(insertProbationQuery, conn))
                            {
                                insertProbationCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                insertProbationCmd.Parameters.AddWithValue("@Token", enteredToken);
                                insertProbationCmd.ExecuteNonQuery();
                            }
                            pw pw = new pw();
                            pw.Show();
                            this.Hide();
                            return;
                        }
                        reader.Close();
                    }
                    string checkVIPQuery = "SELECT * FROM VIP_Passenger WHERE Token = @Token";
                    using (SqlCommand cmdVIP = new SqlCommand(checkVIPQuery, conn))
                    {
                        cmdVIP.Parameters.AddWithValue("@Token", enteredToken);
                        SqlDataReader vipReader = cmdVIP.ExecuteReader();

                        if (vipReader.Read())
                        {
                            string vipName = vipReader["Name"].ToString();
                            string vipEmail = vipReader["Email"].ToString();
                            string vipPhoneNumber = vipReader["Phone_No"].ToString();
                            string vipDOB = vipReader["Date_Of_Birth"].ToString();
                            string vipGender = vipReader["Gender"].ToString();
                            string vipNID = vipReader["NID_No"].ToString();
                            string vipAdd = vipReader["Address"].ToString();

                            vipReader.Close();

                            
                            string insertPassengerQuery = "INSERT INTO Passenger (Name,Email,Phone_No,Date_Of_Birth,Gender,NID_No,Address) VALUES (@Name,@Email,@PhoneNumber,@Date,@Gender,@NID,@Add)";
                            using (SqlCommand insertPassengerCmd = new SqlCommand(insertPassengerQuery, conn))
                            {
                                insertPassengerCmd.Parameters.AddWithValue("@Name", vipName);
                                insertPassengerCmd.Parameters.AddWithValue("@Email", vipEmail);
                                insertPassengerCmd.Parameters.AddWithValue("@PhoneNumber", vipPhoneNumber);
                                insertPassengerCmd.Parameters.AddWithValue("@Date", vipDOB);
                                insertPassengerCmd.Parameters.AddWithValue("@Gender", vipGender);
                                insertPassengerCmd.Parameters.AddWithValue("@NID", vipNID);
                                insertPassengerCmd.Parameters.AddWithValue("@Add", vipAdd);
                                insertPassengerCmd.ExecuteNonQuery();
                            }

                            
                            string insertProbationQuery = "INSERT INTO Probation_Passenger (Name,Email,Phone_No,Date_Of_Birth,Gender,NID_No,Address,Token) VALUES (@Name,@Email,@PhoneNumber,@Date,@Gender,@NID,@Add,@Token)";
                            using (SqlCommand insertProbationCmd = new SqlCommand(insertProbationQuery, conn))
                            {
                                insertProbationCmd.Parameters.AddWithValue("@Name", vipName);
                                insertProbationCmd.Parameters.AddWithValue("@Email", vipEmail);
                                insertProbationCmd.Parameters.AddWithValue("@PhoneNumber", vipPhoneNumber);
                                insertProbationCmd.Parameters.AddWithValue("@Date", vipDOB);
                                insertProbationCmd.Parameters.AddWithValue("@Gender", vipGender);
                                insertProbationCmd.Parameters.AddWithValue("@NID", vipNID);
                                insertProbationCmd.Parameters.AddWithValue("@Add", vipAdd);
                                insertProbationCmd.Parameters.AddWithValue("@Token", enteredToken);
                                insertProbationCmd.ExecuteNonQuery();
                            }

                            
                            pw pw = new pw();
                            pw.Show();
                            this.Hide();
                            return;
                        }

                        vipReader.Close();
                    }

                    
                    MessageBox.Show("Invalid token entered.", "Error");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Error");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }

        private void textBoxgp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxgp.Text != "")
            {
                lblgp.Visible = false;
            }
            else
            {
                lblgp.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
