using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BookHaven_Bookstore_Management_System.Services
{
    public class BookService
    {
        private string connectionString;

       public BookService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAllBooks()
        {
            string query = "SELECT * FROM Books";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
