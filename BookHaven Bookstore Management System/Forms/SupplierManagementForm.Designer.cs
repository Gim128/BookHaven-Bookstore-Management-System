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
            lblName = new Label();
            lblContactInfo = new Label();
            txtName = new TextBox();
            txtContactInfo = new TextBox();
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(38, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Location = new Point(284, 48);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(90, 20);
            lblContactInfo.TabIndex = 1;
            lblContactInfo.Text = "Contact Info";
            // 
            // txtName
            // 
            txtName.Location = new Point(44, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 2;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(284, 78);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(172, 27);
            txtContactInfo.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(573, 48);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 50);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(752, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 50);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(935, 48);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 50);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnGenerateOrder
            // 
            btnGenerateOrder.Location = new Point(573, 118);
            btnGenerateOrder.Name = "btnGenerateOrder";
            btnGenerateOrder.Size = new Size(135, 50);
            btnGenerateOrder.TabIndex = 7;
            btnGenerateOrder.Text = "Generate Order";
            btnGenerateOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Columns.AddRange(new DataGridViewColumn[] { SupplierID, Name, ContactInfo });
            dataGridViewSuppliers.Location = new Point(346, 245);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 51;
            dataGridViewSuppliers.Size = new Size(429, 255);
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
            ClientSize = new Size(1189, 540);
            Controls.Add(dataGridViewSuppliers);
            Controls.Add(btnGenerateOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtContactInfo);
            Controls.Add(txtName);
            Controls.Add(lblContactInfo);
            Controls.Add(lblName);
            Name = "SupplierManagementForm";
            Text = "SupplierManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblContactInfo;
        private TextBox txtName;
        private TextBox txtContactInfo;
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