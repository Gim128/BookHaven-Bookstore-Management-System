using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using BookHaven_Bookstore_Management_System.Helpers;

namespace BookHaven_Bookstore_Management_System.Forms
{
    public partial class LoginForm : Form
    {

        private string connectionString = "Data Source=DESKTOP-1VJ4V7G;Initial Catalog=BookHaven;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole1.SelectedItem.ToString();

            if(ValidateLogin(username, password, role))
            {
                LogLoginAttempt(username,role, true);

                if(role == "Admin")
                {
                    AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
                    adminDashboardForm.Show();
                }
                else if(role == "Sales Clerk")
                {
                    SalesForm salesForm = new SalesForm();
                    salesForm.Show();
                }
                this.Hide();
            }
            else
            {
                LogLoginAttempt(username, role, false);

                MessageBox.Show("Invalid login credentials. Please try again.");
            }
        }

        

        private bool ValidateLogin(string username, string password, string role)
        {
            string query = "SELECT PasswordHash FROM Users WHERE Username = @Username AND Role = @Role";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Role", role);
                connection.Open();
                string passwordHash = cmd.ExecuteScalar().ToString();
                if (passwordHash != null && SecurityHelper.VerifyPasswordHash(password, passwordHash))
                {
                    return true;
                }
            }
            return false;
        }

        private void LogLoginAttempt(string username, string role, bool isSuccessful)
        {
            var loginAttempt = new
            {
                Username = username,
                Role = role,
                isSuccessful = isSuccessful,
                Timestamp = DateTime.Now
            };
            string jsonLog = JsonConvert.SerializeObject(loginAttempt, Formatting.Indented);

            System.IO.File.AppendAllText("LoginAttempts.json", jsonLog + Environment.NewLine);

        }

        
    }
}
