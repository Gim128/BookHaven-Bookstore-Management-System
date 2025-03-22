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
    public partial class BookManagementForm : Form
    {

        private string connectionString = "Data Source=DESKTOP-3S5VJ4I;Initial Catalog=bookstore;Integrated Security=True";
        private readonly object dataGridViewBooks;

        //private DataGridView dataGridViewBooks;

        public BookManagementForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            string query = "SELECT * FROM Books";
            using (SqlConnection connection = new SqlConnection(connectionString)) // Fixed typo in SqlConnection
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewBooks.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
