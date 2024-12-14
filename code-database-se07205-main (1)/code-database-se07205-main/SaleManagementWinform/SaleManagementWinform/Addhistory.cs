using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleManagementWinform
{
    public partial class Addhistory : Form
    {
        public Addhistory()
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
            // Lấy dữ liệu từ các textbox
            string purchaseID = tbx_purchaseID.Text;
            string customerCode = tbx_customerCode.Text;
            string productCode = tbx_productCode.Text;
            string purchaseDate = tbx_purchaseDate.Text;
            string quantity = tbx_quantity.Text;
            string status = tbx_status.Text;

            // Kiểm tra dữ liệu không được để trống
            if (string.IsNullOrWhiteSpace(purchaseID) || string.IsNullOrWhiteSpace(customerCode) ||
                string.IsNullOrWhiteSpace(productCode) || string.IsNullOrWhiteSpace(purchaseDate) ||
                string.IsNullOrWhiteSpace(quantity) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.");
                return;
            }

            // Kiểm tra số lượng có phải là số hợp lệ
            if (!int.TryParse(quantity, out int parsedQuantity) || parsedQuantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.");
                return;
            }

            // Thêm dữ liệu vào cơ sở dữ liệu
            InsertData(purchaseID, customerCode, productCode, purchaseDate, parsedQuantity, status);
        }

        private void InsertData(string purchaseID, string customerCode, string productCode, string purchaseDate, int quantity, string status)
        {
            string query = "INSERT INTO History (PurchaseID, CustomerCode, ProductCode, PurchaseDate, Quantity, Status) " +
                           "VALUES (@PurchaseID, @CustomerCode, @ProductCode, @PurchaseDate, @Quantity, @Status)";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số
                        command.Parameters.AddWithValue("@PurchaseID", purchaseID);
                        command.Parameters.AddWithValue("@CustomerCode", customerCode);
                        command.Parameters.AddWithValue("@ProductCode", productCode);
                        command.Parameters.AddWithValue("@PurchaseDate", DateTime.Parse(purchaseDate)); // Đảm bảo ngày hợp lệ
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@Status", status);

                        // Thực thi lệnh
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid date format. Please enter a valid date (e.g., yyyy-MM-dd).");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu trong các textbox
            tbx_purchaseID.Clear();
            tbx_customerCode.Clear();
            tbx_productCode.Clear();
            tbx_purchaseDate.Clear();
            tbx_quantity.Clear();
            tbx_status.Clear();
        }

        internal void ShowDialag()
        {
            throw new NotImplementedException();
        }
    }
}

