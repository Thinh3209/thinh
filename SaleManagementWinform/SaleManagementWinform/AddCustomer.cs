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

namespace SaleManagementWinform
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();

            // thiết lập giao diện ở trung tâm màn hình 

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;


            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string code = tbx_code.Text;
            string name = tbx_name.Text;
            string phone = tbx_phone.Text;
            string address = tbx_address.Text;


            InsertData(code, name, phone, address);






        }




        private void InsertData(string code, string name, string phoneNumber, string address)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO Customer (code, name, phoneNumber, address, active) VALUES (@code, @name, @phoneNumber, @address, 1)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@address", address);
                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
