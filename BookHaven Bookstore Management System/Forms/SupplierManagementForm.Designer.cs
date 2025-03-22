namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class SupplierManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtContactInfo = new TextBox();
            lblName = new Label();
            lblContact = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnGenerateOrder = new Button();
            dataGridViewSuppliers = new DataGridView();
            SupplierID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ContactInfo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 0;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(332, 68);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(242, 27);
            txtContactInfo.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(49, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(327, 39);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 20);
            lblContact.TabIndex = 3;
            lblContact.Text = "Contact";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(54, 147);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 53);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(268, 147);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 53);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(477, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 53);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGenerateOrder
            // 
            btnGenerateOrder.Location = new Point(888, 76);
            btnGenerateOrder.Name = "btnGenerateOrder";
            btnGenerateOrder.Size = new Size(183, 50);
            btnGenerateOrder.TabIndex = 7;
            btnGenerateOrder.Text = "Generate Order";
            btnGenerateOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierID, Name, ContactInfo });
            dataGridViewSuppliers.Location = new Point(61, 252);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.Size = new Size(429, 282);
            dataGridViewSuppliers.TabIndex = 8;
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "SupplierID";
            SupplierID.MinimumWidth = 6;
            SupplierID.Name = "SupplierID";
            SupplierID.ReadOnly = true;
            SupplierID.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // ContactInfo
            // 
            ContactInfo.HeaderText = "ContactInfo";
            ContactInfo.MinimumWidth = 6;
            ContactInfo.Name = "ContactInfo";
            ContactInfo.Width = 125;
            // 
            // SupplierManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 549);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(btnGenerateOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblContact);
            Controls.Add(lblName);
            Controls.Add(txtContactInfo);
            Controls.Add(txtName);
            Name = "SupplierManagementForm";
            Text = "SupplierManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtContactInfo;
        private Label lblName;
        private Label lblContact;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnGenerateOrder;
        private DataGridView dataGridViewSuppliers;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ContactInfo;
    }
}