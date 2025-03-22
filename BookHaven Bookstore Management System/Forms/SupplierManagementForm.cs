using BookHaven_Bookstore_Management_System.Services;
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
    public partial class SupplierManagementForm: Form
    {

        private SupplierService supplierService;
        public SupplierManagementForm()
        {
            InitializeComponent();
            supplierService = new SupplierService("");
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            DataTable suppliers = supplierService.GetAllSuppliers();
            dataGridViewSuppliers.DataSource = suppliers;
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

            supplierService.AddSupplier(name, contactInfo);
            LoadSuppliers(); // Refresh the DataGridView
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtContactInfo.Clear();
        }

        private void dataGridViewSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSuppliers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewSuppliers.SelectedRows[0];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtContactInfo.Text = row.Cells["ContactInfo"].Value.ToString();
            }
        }
    }
}
