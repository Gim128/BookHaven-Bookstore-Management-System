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
using BookHaven_Bookstore_Management_System.Services;


namespace BookHaven_Bookstore_Management_System.Forms
{

    public partial class OrderManagementForm : Form
    {
        //private string connectionString = "Data Source=DESKTOP-3S5VJ8I;Initial Catalog=BookHaven;Integrated Security=True";
        private OrderService orderService;
        private CustomerService customerService;
        private BookService bookService;

        public OrderManagementForm()
        {
            InitializeComponent();
            orderService = new OrderService("Your_Connection_String_Here");
            customerService = new CustomerService("Your_Connection_String_Here");
            bookService = new BookService("Your_Connection_String_Here");
            LoadCustomers();
            LoadBooks();
            LoadOrders();
        }

        private void LoadBooks()
        {
            DataTable books = bookService.GetAllBooks();
            cmbBooks.DataSource = books;
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookID";
        }

        private void LoadOrders()
        {
            //string query = "SELECT * FROM Orders";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    dataGridViewOrder.DataSource = table;
            //}
            DataTable orders = orderService.GetAllOrders();
            dataGridViewOrder.DataSource = orders;


        }

        private void LoadCustomers()
        {
            //string query = "SELECT CustomerID, Name FROM Customers";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);
            //    cmbSelectCustomers.DataSource = table;
            //    cmbSelectCustomers.DisplayMember = "Name";
            //    cmbSelectCustomers.ValueMember = "CustomerID";
            //}

            DataTable customers = customerService.GetAllCustomers();
            cmbSelectCustomers.DataSource = customers;
            cmbSelectCustomers.DisplayMember = "Name";
            cmbSelectCustomers.ValueMember = "CustomerID";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int customerID = (int)cmbSelectCustomers.SelectedValue;
            int bookID = (int)cmbBooks.SelectedValue;
            int quantity = (int)numQuantity.Value;
            decimal totalCost = GetBookPrice(bookID) * quantity;
            string status = cmbStatus.SelectedItem.ToString();
            string deliveryOption = cmbDeliveryOption.SelectedItem.ToString();

            orderService.PlaceOrder(customerID, bookID, quantity, totalCost, status, deliveryOption);
            LoadOrders();
        }

        private int GetBookPrice(int bookID)
        {
            string query = "SELECT Price FROM Books WHERE BookID = @BookID";
            using (SqlConnection conn = new SqlConnection("Your_Connection_String_Here"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                conn.Open();
                return (int)(decimal)cmd.ExecuteScalar();
            }
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to track.");
                return;
            }

            int orderID = (int)dataGridViewOrder.SelectedRows[0].Cells["OrderID"].Value;
            DataTable orderDetails = orderService.GetOrderDetails(orderID);

            // Display order details in a message box or a new form
            MessageBox.Show($"Order Details for Order ID {orderID}:\n{orderDetails.Rows[0]["Status"]}");
        }
    }
}
