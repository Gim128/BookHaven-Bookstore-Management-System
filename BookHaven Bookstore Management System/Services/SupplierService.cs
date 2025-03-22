using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookHaven_Bookstore_Management_System.Services
{
    public class SupplierService
    {
        private string connectionString;

        public SupplierService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetAllSuppliers()
        {
            string query = "SELECT * FROM suppliers";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void AddSupplier(string name, string contactInfo)
        {
            string query = "INSERT INTO suppliers (name, contact_info) VALUES (@name, @contactInfo)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contactInfo", contactInfo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSupplier(int supplierID, string name, string contactInfo)
        {
            string query = "UPDATE suppliers SET name = @Name, contact_info = @ContactInfo WHERE SupplierID = @SupplierID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", supplierID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@contactInfo", contactInfo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSupplier(int supplierID)
        {
            string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
