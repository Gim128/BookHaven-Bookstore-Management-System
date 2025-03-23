using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookHaven_Bookstore_Management_System.Services
{
    public class AdminDashboardService
    {
        private string connectionString;

        public AdminDashboardService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public decimal GetTotalSales()
        {
            string query = "SELECT SUM(TotalAmount) FROM Sales";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
        }

        public DataTable GetLowStockItems()
        {
            string query = "SELECT Title, StockQuantity FROM Books WHERE StockQuantity < 10";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetRecentCustomerActivity()
        {
            string query = "SELECT TOP 10 Customers.Name, Sales.TotalAmount, Sales.SaleDate " +
                           "FROM Sales " +
                           "INNER JOIN Customers ON Sales.CustomerID = Customers.CustomerID " +
                           "ORDER BY Sales.SaleDate DESC";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetStaffPerformance()
        {
            string query = "SELECT Username, COUNT(SaleID) AS TotalSales, SUM(TotalAmount) AS TotalRevenue " +
                           "FROM Sales " +
                           "INNER JOIN Users ON Sales.UserID = Users.UserID " +
                           "GROUP BY Username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


    }
}
