using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Services
{
    public class CustomerService
    {
        private string connectionString;

        public CustomerService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAllCustomers()
        {
            string query = "SELECT * FROM Customers";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddCustomer(string name, string contactInfo)
        {
            string query = "INSERT INTO Customers (Name, ContactInfo, PurchaseHistory) VALUES (@Name, @ContactInfo, @PurchaseHistory)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                cmd.Parameters.AddWithValue("@PurchaseHistory", "[]"); // Initialize with empty JSON array
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(int customerID, string name, string contactInfo)
        {
            string query = "UPDATE Customers SET Name = @Name, ContactInfo = @ContactInfo WHERE CustomerID = @CustomerID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@ContactInfo", contactInfo);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int customerID)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePurchaseHistory(int customerID, string purchaseHistory)
        {
            string query = "UPDATE Customers SET PurchaseHistory = @PurchaseHistory WHERE CustomerID = @CustomerID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PurchaseHistory", purchaseHistory);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        internal string GetPurchaseHistory(int customerID)
        {
            throw new NotImplementedException();
        }
    }
}
