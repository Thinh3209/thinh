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
    public partial class CustomerForm : Form
    {

        public static string connectionString
          = "Server=TIENTHINH\\TIENTHINH;Database=Thinh3209;Trusted_Connection=True;";


        public CustomerForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally, set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData();


            dgv_customer.CellClick += dataGridView1_CellClick;

        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM Customer where active = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with query results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgv_customer.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dgv_customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.LoadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_customer.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["code"].Value.ToString();
                var name = selectedRow.Cells["name"].Value.ToString();
                var phone = selectedRow.Cells["phoneNumber"].Value.ToString();
                var address = selectedRow.Cells["address"].Value.ToString();


                UpdateCustomer updateForm = new UpdateCustomer(code, name, phone, address);
                updateForm.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
