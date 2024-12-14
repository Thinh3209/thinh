using SaleManagementWinform;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

private void button1_Click(object sender, EventArgs e)
{
    string code = tbx_code.Text;
    string name = tbx_name.Text;
    string phone = tbx_phone.Text;
    string address = tbx_address.Text;

    if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) ||
        string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
    {
        MessageBox.Show("All fields are required. Please fill in all fields.");
        return;
    }

    // Kiểm tra định dạng số điện thoại
    if (!IsValidPhoneNumber(phone))
    {
        MessageBox.Show("Invalid phone number format. Please enter a valid phone number.");
        return;
    }

    InsertData(code, name, phone, address);
}

// Hàm kiểm tra số điện thoại hợp lệ
private bool IsValidPhoneNumber(string phoneNumber)
{
    // Regex kiểm tra số điện thoại (ví dụ: chỉ chứa số và có độ dài 10-11 ký tự)
    return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
}

private void InsertData(string code, string name, string phoneNumber, string address)
{
    string query = "INSERT INTO Customer (code, name, phoneNumber, address) VALUES (@code, @name, @phoneNumber, @address)";

    using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
    {
        try
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@address", address);

                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} row(s) inserted successfully.");
            }
        }
        catch (SqlException ex) when (ex.Message.Contains("CHECK constraint"))
        {
            MessageBox.Show("The phone number does not meet the database constraints. Please check the input.");
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message);
        }
    }
}
