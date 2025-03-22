using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BookHaven_Bookstore_Management_System.Services;

namespace BookHaven_Bookstore_Management_System.Forms
{
    public partial class CustomerManagementForm: Form
    {

        private CustomerService customerService;

        public CustomerManagementForm()
        {
            InitializeComponent();
            customerService = new CustomerService("connection_name");
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            DataTable customers = customerService.GetAllCustomers();
            dataGridViewCustomers.DataSource = customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string contactInfo = txtContactInfo.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactInfo))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            customerService.AddCustomer(name, contactInfo);
            LoadCustomers(); // Refresh the DataGridView
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtContactInfo.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            int customerID = int.Parse(dataGridViewCustomers.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            string name = txtName.Text;
            string contactInfo = txtContactInfo.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contactInfo))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            customerService.UpdateCustomer(customerID, name, contactInfo);
            LoadCustomers(); // Refresh the DataGridView
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            int customerID = int.Parse(dataGridViewCustomers.SelectedRows[0].Cells["CustomerID"].Value.ToString());

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                customerService.DeleteCustomer(customerID);
                LoadCustomers(); // Refresh the DataGridView
                ClearFields();
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to view purchase history.");
                return;
            }

            int customerID = int.Parse(dataGridViewCustomers.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            string purchaseHistory = customerService.GetPurchaseHistory(customerID);

            // Display purchase history in a message box or a new form
            MessageBox.Show($"Purchase History for Customer ID {customerID}:\n{purchaseHistory}");
        }


        private void dataGridViewCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewCustomers.SelectedRows[0];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContactInfo.Text = row.Cells["ContactInfo"].Value.ToString();
            }
        }

    }
}
