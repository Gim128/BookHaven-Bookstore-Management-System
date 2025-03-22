namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class CustomerManagementForm
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
            txtName = new TextBox();
            txtContactInfo = new TextBox();
            lblContactInfo = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnViewHistory = new Button();
            dataGridViewCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            ContactInfo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(48, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(48, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 27);
            txtName.TabIndex = 1;
            // 
            // txtContactInfo
            // 
            txtContactInfo.Location = new Point(289, 93);
            txtContactInfo.Name = "txtContactInfo";
            txtContactInfo.Size = new Size(210, 27);
            txtContactInfo.TabIndex = 2;
            // 
            // lblContactInfo
            // 
            lblContactInfo.AutoSize = true;
            lblContactInfo.Location = new Point(289, 60);
            lblContactInfo.Name = "lblContactInfo";
            lblContactInfo.Size = new Size(90, 20);
            lblContactInfo.TabIndex = 3;
            lblContactInfo.Text = "Contact Info";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(672, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 44);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(832, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 44);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(672, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 44);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(832, 111);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(135, 44);
            btnViewHistory.TabIndex = 7;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, Name, ContactInfo });
            dataGridViewCustomers.Location = new Point(48, 170);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.Size = new Size(429, 277);
            dataGridViewCustomers.TabIndex = 8;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Width = 125;
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
            // CustomerManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 506);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(btnViewHistory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblContactInfo);
            Controls.Add(txtContactInfo);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "CustomerManagementForm";
            Text = "CustomerManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtContactInfo;
        private Label lblContactInfo;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnViewHistory;
        private DataGridView dataGridViewCustomers;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn ContactInfo;
    }
}