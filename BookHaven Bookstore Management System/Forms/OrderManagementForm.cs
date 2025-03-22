using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BookHaven_Bookstore_Management_System.Forms
{

    public partial class OrderManagementForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-3S5VJ8I;Initial Catalog=BookHaven;Integrated Security=True";

        public OrderManagementForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadOrders();
        }

        private void LoadOrders()
        {
            string query = "SELECT * FROM Orders";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewOrder.DataSource = table;
            }

        }

        private void LoadCustomers()
        {
            string query = "SELECT CustomerID, Name FROM Customers";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmbSelectCustomers.DataSource = table;
                cmbSelectCustomers.DisplayMember = "Name";
                cmbSelectCustomers.ValueMember = "CustomerID";
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(cmbSelectCustomers.SelectedValue.ToString());
            int bookID = int.Parse(txtBookID.Text);
            int quantity = int.Parse(txtQuantity.Text);
            decimal totalCost = decimal.Parse(txtTotalCost.Text);

            string query = "INSERT INTO Orders (CustomerID, BookID, Quantity, TotalCost, OrderDate, Status) VALUES (@CustomerID, @BookID, @Quantity, @TotalCost, OrderDate, @Status)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@CustomerID", customerID);
                sqlCommand.Parameters.AddWithValue("@BookID", bookID);
                sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
                sqlCommand.Parameters.AddWithValue("@TotalCost", totalCost);
                sqlCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@Status", "Pending");
                conn.Open();
                sqlCommand.ExecuteNonQuery();
            }

            LoadOrders();
        }
    }
}
