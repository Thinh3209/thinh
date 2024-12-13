using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleManagementWinform
{
    public partial class UpdateCustomer : Form
    {
       

        public UpdateCustomer(string code, string name, string phoneNumber, string address)
        {
            InitializeComponent();
            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
            // Disable the maximize/restore button
            this.MaximizeBox = false;
            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            tbx_code.Text = code + "";
            tbx_name.Text = name + "";
            tbx_address.Text = address;
            tbx_phone.Text = phoneNumber;
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {

        }


        private void UpdateCustomerInDatabase(string code, string name, string phoneNumber,string address)
        {
            string query = "UPDATE Customer SET name = @name, code = @code, " +
                "address = @address, phoneNumber = @phoneNumber WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No Customer found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void DeleteCustomerFromDatabase(string code)
        {
            string query = "UPDATE Customer SET active = 0 WHERE code = @code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@code", code);
                      
                        // Execute the update command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No Customer found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = tbx_code.Text;
            string name = tbx_name.Text;
            string address = tbx_address.Text.ToString().Trim();
            string phoneNumber =tbx_phone.Text.ToString();


            UpdateCustomerInDatabase(code, name,  phoneNumber, address);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure you want to delete this customer?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Call method to delete the product from the database
                DeleteCustomerFromDatabase(tbx_code.Text.ToString());
            }
        }
    }
}
