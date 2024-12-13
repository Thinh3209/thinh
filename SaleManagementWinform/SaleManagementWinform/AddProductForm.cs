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
    public partial class AddProductForm : Form
    {

      
        public AddProductForm()
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
            string MaSP = txb_code.Text.ToString();
            string TenSP = txb_name.Text.ToString();
            int SoLuong = int.Parse(txb_amount.Text.ToString());
            int Gia = int.Parse(txb_price.Text.ToString());

            InsertData(MaSP, TenSP, SoLuong, Gia);



        }


        private void InsertData(string code, string name, int ammount, int price)
        {
            // Connection string to your database

            // SQL query to insert data
            string query = "INSERT INTO Product (Code, Name, Quantity, Price) VALUES (@Code, @Name, @Quantity, @Price, 1)";

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
                        command.Parameters.AddWithValue("@Name", name);

                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Quantity", ammount);
                        command.Parameters.AddWithValue("@Price", price);


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

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
