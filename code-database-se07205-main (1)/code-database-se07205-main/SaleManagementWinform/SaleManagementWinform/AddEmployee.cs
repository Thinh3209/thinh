using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = tbx_name.Text;
            string code = tbx_code.Text;
            string username = tbx_username.Text;
            string password = tbx_password.Text; // Plain password, no hashing

            string position = tbx_position.Text;

            int roleID = 2;

            // Insert data without password hashing
            InsertData(code, fullname, position, roleID, username, password);
        }

        private void InsertData(string code, string name, string position, int roleID, string username, string password)
        {
            // Connection string to your database
            string query = "INSERT INTO Employee (code, name, position, username, password) VALUES (@code, @name, @position, @username, @password)";

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
                        command.Parameters.AddWithValue("@position", position);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); // Store the plain password

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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // Handle form load if necessary
        }
    }
}
