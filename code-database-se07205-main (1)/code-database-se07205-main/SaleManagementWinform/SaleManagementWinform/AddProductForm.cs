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
            string MaSP = txb_code.Text;
            string TenSP = txb_name.Text;

            if (!int.TryParse(txb_amount.Text, out int SoLuong))
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
                return;
            }

            if (!int.TryParse(txb_price.Text, out int Gia))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            InsertData(MaSP, TenSP, SoLuong, Gia);
        }

        private void InsertData(string code, string name, int amount, int price)
        {
            string query = "INSERT INTO Product (Code, Name, Quantity, Price) VALUES (@Code, @Name, @Quantity, @Price)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Quantity", amount);
                        command.Parameters.AddWithValue("@Price", price);

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

        private void DeleteData(string code)
        {
            string query = "DELETE FROM Product WHERE Code = @Code";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified code.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MaSP = txb_code.Text;

            if (string.IsNullOrWhiteSpace(MaSP))
            {
                MessageBox.Show("Please enter the product code to delete.");
                return;
            }

            DeleteData(MaSP);
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
