using BookHaven_Bookstore_Management_System.Services;
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

namespace BookHaven_Bookstore_Management_System.Forms
{
    public partial class SalesForm : Form
    {

        private string connectionString = "Data Source=DESKTOP-1VJ4VU5;Initial Catalog=BookHaven;Integrated Security=True";
        private DataTable cart;
        private SalesService salesService;

        public SalesForm()
        {
            InitializeComponent();
            salesService = new SalesService("Your_Connection_String_Here");
            InitializeComponent();
            LoadBooks();

        }

        private void InitializeCart()
        {
            cart = new DataTable();
            cart.Columns.Add("BookID", typeof(int));
            cart.Columns.Add("Title", typeof(string));
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("Price", typeof(decimal));
            cart.Columns.Add("Total", typeof(decimal));
            dataGridViewCart.DataSource = cart;
        }

        private void LoadBooks()
        {
            DataTable books = salesService.GetAllBooks();
            cmbSelectBooks.DataSource = books;
            cmbSelectBooks.DisplayMember = "Title";
            cmbSelectBooks.ValueMember = "BookID";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            decimal subtotal = 0;
            foreach (DataRow row in cart.Rows)
            {
                subtotal += (decimal)row["Total"];
            }

            decimal discount = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : decimal.Parse(txtDiscount.Text);
            decimal totalCost = subtotal - (subtotal * discount / 100);

            lblTotalCost.Text = $"Total Cost: {totalCost:C}";
        }

        

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (cart.Rows.Count == 0)
            {
                MessageBox.Show("No items in the cart.");
                return;
            }

            foreach (DataRow row in cart.Rows)
            {
                int bookID = (int)row["BookID"];
                int quantity = (int)row["Quantity"];
                decimal totalAmount = (decimal)row["Total"];

                salesService.ProcessSale(bookID, quantity, totalAmount);
            }

            MessageBox.Show("Receipt generated and inventory updated.");
            cart.Clear();
            lblTotalCost.Text = "Total Cost: $0.00";
        }



        private void UpdateInventory(int bookID, int quantity)
        {
            string query = "UPDATE Books SET Quantity = Quantity - @Quantity WHERE BookID = @BookID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
                sqlCommand.Parameters.AddWithValue("@BookID", bookID);
                conn.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int bookID = (int)cmbSelectBooks.SelectedValue;
            string title = cmbSelectBooks.Text;
            int quantity = (int)cmbSelectBooks.SelectedValue;
            decimal price = GetBookPrice(bookID);
            decimal total = quantity * price;

            cart.Rows.Add(bookID, title, quantity, price, total);
            dataGridViewCart.DataSource = cart;
        }

        private decimal GetBookPrice(int bookID)
        {
            string query = "SELECT Price FROM Books WHERE BookID = @BookID";
            using (SqlConnection conn = new SqlConnection("Your_Connection_String_Here"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                conn.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }
    }
}

