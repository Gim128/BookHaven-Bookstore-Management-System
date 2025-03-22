using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Services
{
    public class SalesService
    {
        private string connectionString;

        public SalesService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAllBooks()
        {
            string query = "SELECT BookID, Title, Price FROM Books";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void ProcessSale(int bookID, int quantity, decimal totalAmount)
        {
            string query = "INSERT INTO Sales (BookID, Quantity, TotalAmount, SaleDate) VALUES (@BookID, @Quantity, @TotalAmount, @SaleDate)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            // Update inventory
            UpdateInventory(bookID, quantity);
        }

        private void UpdateInventory(int bookID, int quantity)
        {
            string query = "UPDATE Books SET StockQuantity = StockQuantity - @Quantity WHERE BookID = @BookID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
