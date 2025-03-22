using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Services
{
    public class OrderService
    {
        private string connectionString;

        public OrderService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAllOrders()
        {
            string query = "SELECT Orders.OrderID, Customers.Name AS CustomerName, Books.Title AS BookTitle, Orders.Quantity, Orders.TotalCost, Orders.OrderDate, Orders.Status, Orders.DeliveryOption " +
                           "FROM Orders " +
                           "INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID " +
                           "INNER JOIN Books ON Orders.BookID = Books.BookID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void PlaceOrder(int customerID, int bookID, int quantity, decimal totalCost, string status, string deliveryOption)
        {
            string query = "INSERT INTO Orders (CustomerID, BookID, Quantity, TotalCost, OrderDate, Status, DeliveryOption) " +
                           "VALUES (@CustomerID, @BookID, @Quantity, @TotalCost, @OrderDate, @Status, @DeliveryOption)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalCost", totalCost);
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@DeliveryOption", deliveryOption);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(int orderID, string status)
        {
            string query = "UPDATE Orders SET Status = @Status WHERE OrderID = @OrderID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetOrderDetails(int orderID)
        {
            string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@OrderID", orderID);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}
