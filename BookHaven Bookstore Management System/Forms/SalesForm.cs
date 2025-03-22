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
        private DataTable cart = new DataTable();

        public SalesForm()
        {
            InitializeComponent();
            LoadBooks();
            cart.Columns.Add("BookID", typeof(int));
            cart.Columns.Add("Title", typeof(string));
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("Price", typeof(decimal));
            cart.Columns.Add("Total", typeof(decimal));
            dataGridViewCart.DataSource = cart;
        }

        private void LoadBooks()
        {
            string query = "SELECT BookID, Title, Price FROM Books";
            using (SqlConnecction conn = new SqlConnecction(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable books = new DataTable();
                adapter.Fill(books);
                cmbSelectBooks.DataSource = books;
                cmbSelectBooks.DisplayMember = "Title";
                cmbSelectBooks.ValueMember = "BookID";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int bookID = int.Parse(cmbSelectBooks.SelectedValue.ToString());
            string title = cmbSelectBooks.Text;
            int quantity = int.Parse(txtQuantity.Text);
            decimal price = decimal.Parse(cmbSelectBooks.Text);
            decimal total = quantity * price;

            cart.Rows.Add(bookID, title, quantity, price, total);
            dataGridViewCart.DataSource = cart;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in cart.Rows)
            {
                int bookID = int.Parse(row["BookID"].ToString());
                int quantity = int.Parse(row["Quantity"].ToString());
                UpdateInventory(bookID, quantity);
            }
            MessageBox.Show("Receipt generated successfully");
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
    }
    }
}
