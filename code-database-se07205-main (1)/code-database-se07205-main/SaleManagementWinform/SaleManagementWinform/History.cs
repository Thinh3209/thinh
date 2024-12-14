using System;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaleManagementWinform
{
    public partial class History : Form
    {



        public History()
        {
            InitializeComponent();

            // Maximize the form and keep it above the Taskbar
            this.WindowState = FormWindowState.Maximized;

            // Set the form border style to ensure it has a standard window look
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Optionally, set StartPosition to CenterScreen if you want centered loading
            this.StartPosition = FormStartPosition.CenterScreen;
            // dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.LoadData();
            SetupDataGridView();
            /// dgv_product.CellPainting += dataGridView1_CellPainting;

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if the cell belongs to the Edit or Delete button columns
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgv_history.Columns[e.ColumnIndex].Name == "Edit" || dgv_history.Columns[e.ColumnIndex].Name == "Delete")
                {
                    // Prevent default button painting
                    e.PaintBackground(e.CellBounds, true);

                    // Create a solid brush for button background
                    Brush buttonBrush;
                    if (dgv_history.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        buttonBrush = new SolidBrush(Color.Green); // Green for Edit
                    }
                    else
                    {
                        buttonBrush = new SolidBrush(Color.Red); // Red for Delete
                    }

                    // Draw the button with the custom color
                    e.Graphics.FillRectangle(buttonBrush, e.CellBounds);

                    // Draw the button text
                    TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, e.CellBounds, e.CellStyle.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true; // Prevent default cell painting
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the cell belongs to the Edit or Delete button columns
            if (dgv_history.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Set the background color for the Edit button to green

                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
            }
            else if (dgv_history.Columns[e.ColumnIndex].Name == "Delete")
            {
                // Set the background color for the Delete button to red
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dgv_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadData()
        {
            // SQL query to fetch data
            string query = "SELECT * FROM PurchaseHistory ";

            using (SqlConnection connection = new SqlConnection(Connection.SQLConnection))
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
                    dgv_history.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Handle any errors that may occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void SetupDataGridView()
        {
            // Add Edit button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            dgv_history.Columns.Add(editButtonColumn);

            // Add Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv_history.Columns.Add(deleteButtonColumn);

            // Optional: Adjust column widths
            dgv_history.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Handle button clicks
            dgv_history.CellClick += dataGridView1_CellClick;


        }

        /*  private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              // Check if the clicked cell is within the bounds of the grid
              if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
              {
                  // Identify which column was clicked
                  if (dgv_product.Columns[e.ColumnIndex].Name == "Edit")
                  {
                      // Edit button clicked
                      int id = Convert.ToInt32(dgv_product.Rows[e.RowIndex].Cells["ID"].Value);
                      string name = dgv_product.Rows[e.RowIndex].Cells["Name"].Value.ToString();

                      MessageBox.Show($"Edit button clicked for ID: {id}, Name: {name}");
                      // Add your editing logic here
                  }
                  else if (dgv_product.Columns[e.ColumnIndex].Name == "Delete")
                  {
                      // Delete button clicked
                      int id = Convert.ToInt32(dgv_product.Rows[e.RowIndex].Cells["ID"].Value);

                      // Confirm delete
                      DialogResult result = MessageBox.Show($"Are you sure you want to delete ID: {id}?",
                                                            "Confirm Delete",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

                      if (result == DialogResult.Yes)
                      {
                          dgv_product.Rows.RemoveAt(e.RowIndex);
                          MessageBox.Show($"Row with ID: {id} deleted.");
                          // Add your deletion logic here (e.g., deleting from the database)
                      }
                  }
              }
          }*/


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv_history.Rows[e.RowIndex];

                // Retrieve data from each cell in the selected row
                var code = selectedRow.Cells["Code"].Value.ToString();
                var name = selectedRow.Cells["Name"].Value.ToString();
                var price = int.Parse(selectedRow.Cells["Price"].Value.ToString());
                var quantity = int.Parse(selectedRow.Cells["Quantity"].Value.ToString());

                // Display data in textboxes or labels, or use it as needed
                /*  txtID.Text = id.ToString();
                  txtName.Text = name;
                  txtAge.Text = age.ToString();*/

                // MessageBox.Show($"Code  : {code}, Name: {name}, Price: {price},  Quantity: {quantity}");


                UpdateProduct updateProduct = new UpdateProduct(code, name, price, quantity);
                updateProduct.ShowDialog();

            }
        }
        private void dgv_product_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            AddProductForm form = new AddProductForm();

            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            LoadData();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            MenuForm menu = new MenuForm();
            menu.Show(); // Hiển thị màn hình Menu lên đầu  
            // Ẩn giao diện của màn hình hiện tại 
            this.Hide();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm();

            form.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Addhistory form = new Addhistory();
            form.ShowDialog;

        }
    }
}
