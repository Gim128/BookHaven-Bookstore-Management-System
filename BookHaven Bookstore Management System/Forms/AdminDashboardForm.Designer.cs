namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class AdminDashboardForm
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
            lblTotalSales = new Label();
            lblLowStocksItems = new Label();
            lblRecentCustomerActivity = new Label();
            lblStaffPerformance = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnManageUsers = new Button();
            btnModifyBusinessDetails = new Button();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(41, 33);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(87, 20);
            lblTotalSales.TabIndex = 0;
            lblTotalSales.Text = "Total Sales :";
            // 
            // lblLowStocksItems
            // 
            lblLowStocksItems.AutoSize = true;
            lblLowStocksItems.Location = new Point(379, 33);
            lblLowStocksItems.Name = "lblLowStocksItems";
            lblLowStocksItems.Size = new Size(129, 20);
            lblLowStocksItems.TabIndex = 1;
            lblLowStocksItems.Text = "Low Stocks Items :";
            // 
            // lblRecentCustomerActivity
            // 
            lblRecentCustomerActivity.AutoSize = true;
            lblRecentCustomerActivity.Location = new Point(747, 33);
            lblRecentCustomerActivity.Name = "lblRecentCustomerActivity";
            lblRecentCustomerActivity.Size = new Size(181, 20);
            lblRecentCustomerActivity.TabIndex = 2;
            lblRecentCustomerActivity.Text = "Recent Customer Activity :";
            // 
            // lblStaffPerformance
            // 
            lblStaffPerformance.AutoSize = true;
            lblStaffPerformance.Location = new Point(45, 94);
            lblStaffPerformance.Name = "lblStaffPerformance";
            lblStaffPerformance.Size = new Size(134, 20);
            lblStaffPerformance.TabIndex = 3;
            lblStaffPerformance.Text = "Staff Performance :";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(213, 205);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(754, 335);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(746, 302);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(746, 302);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(673, 94);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(138, 46);
            btnManageUsers.TabIndex = 5;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnModifyBusinessDetails
            // 
            btnModifyBusinessDetails.Location = new Point(826, 94);
            btnModifyBusinessDetails.Name = "btnModifyBusinessDetails";
            btnModifyBusinessDetails.Size = new Size(199, 46);
            btnModifyBusinessDetails.TabIndex = 6;
            btnModifyBusinessDetails.Text = "Modify Business Details";
            btnModifyBusinessDetails.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(746, 302);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Title, StockQuantity });
            dataGridView1.Location = new Point(25, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(303, 265);
            dataGridView1.TabIndex = 0;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // StockQuantity
            // 
            StockQuantity.HeaderText = "Stock Quantity";
            StockQuantity.MinimumWidth = 6;
            StockQuantity.Name = "StockQuantity";
            StockQuantity.Width = 125;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 552);
            Controls.Add(btnModifyBusinessDetails);
            Controls.Add(btnManageUsers);
            Controls.Add(tabControl1);
            Controls.Add(lblStaffPerformance);
            Controls.Add(lblRecentCustomerActivity);
            Controls.Add(lblLowStocksItems);
            Controls.Add(lblTotalSales);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalSales;
        private Label lblLowStocksItems;
        private Label lblRecentCustomerActivity;
        private Label lblStaffPerformance;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn StockQuantity;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnManageUsers;
        private Button btnModifyBusinessDetails;
    }
}