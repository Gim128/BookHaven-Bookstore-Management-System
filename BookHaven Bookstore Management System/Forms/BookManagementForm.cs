using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven_Bookstore_Management_System.Forms
{
    public partial class BookManagementForm : Form
    {
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewBooks.Columns.Clear();

            dataGridViewBooks.Columns.Add("BookID", "Book ID");
            dataGridViewBooks.Columns.Add("Title", "Title");
            dataGridViewBooks.Columns.Add("Author", "Author");
            dataGridViewBooks.Columns.Add("Genre", "Genre");
            dataGridViewBooks.Columns.Add("ISBN", "ISBN");
            dataGridViewBooks.Columns.Add("Price", "Price");
            dataGridViewBooks.Columns.Add("StockQuantity", "Stock Quantity");

            dataGridViewBooks.Columns["BookID"].ReadOnly = true;
        }
    }
}
