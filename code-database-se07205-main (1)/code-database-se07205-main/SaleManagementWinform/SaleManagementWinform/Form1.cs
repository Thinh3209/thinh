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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the form to start in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Disable the maximize/restore button
            this.MaximizeBox = false;

            // Optional: Set a fixed border style to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txb_username.Text;
            string password = txb_password.Text;

            bool checkLogin = CheckLogin(username, password);

            if (checkLogin)
            {
                MenuForm main = new MenuForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect !");
            }
        }

        private bool CheckLogin(string username, string password)
        {
            string query = "SELECT password FROM Employee WHERE username = @username";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString(); // Retrieved plain text password
                        return storedPassword == password; // Compare plain text passwords
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            return false; // Return false if username not found or any error occurs
        }

        private void txb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
