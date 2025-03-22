namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class OrderManagementForm
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
            cmbSelectCustomers = new ComboBox();
            btnPlaceOrder = new Button();
            btnUpdateStatus = new Button();
            btnTrackOrder = new Button();
            label1 = new Label();
            dataGridViewOrder = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            BookID = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalCost = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // cmbSelectCustomers
            // 
            cmbSelectCustomers.FormattingEnabled = true;
            cmbSelectCustomers.Location = new Point(61, 76);
            cmbSelectCustomers.Name = "cmbSelectCustomers";
            cmbSelectCustomers.Size = new Size(270, 28);
            cmbSelectCustomers.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(203, 147);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(181, 45);
            btnPlaceOrder.TabIndex = 1;
            btnPlaceOrder.Text = "PlaceOrder";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(417, 147);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(182, 47);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnTrackOrder
            // 
            btnTrackOrder.Location = new Point(635, 146);
            btnTrackOrder.Name = "btnTrackOrder";
            btnTrackOrder.Size = new Size(181, 47);
            btnTrackOrder.TabIndex = 3;
            btnTrackOrder.Text = "Track Order";
            btnTrackOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 42);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 4;
            label1.Text = "Select Customers";
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Columns.AddRange(new DataGridViewColumn[] { CustomerID, BookID, Quantity, TotalCost, OrderDate, Status });
            dataGridViewOrder.Location = new Point(134, 240);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.Size = new Size(802, 285);
            dataGridViewOrder.TabIndex = 5;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "Column1";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Width = 125;
            // 
            // BookID
            // 
            BookID.HeaderText = "BookID";
            BookID.MinimumWidth = 6;
            BookID.Name = "BookID";
            BookID.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // TotalCost
            // 
            TotalCost.HeaderText = "TotalCost";
            TotalCost.MinimumWidth = 6;
            TotalCost.Name = "TotalCost";
            TotalCost.Width = 125;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "OrderDate";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 537);
            Controls.Add(dataGridViewOrder);
            Controls.Add(label1);
            Controls.Add(btnTrackOrder);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnPlaceOrder);
            Controls.Add(cmbSelectCustomers);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSelectCustomers;
        private Button btnPlaceOrder;
        private Button btnUpdateStatus;
        private Button btnTrackOrder;
        private Label label1;
        private DataGridView dataGridViewOrder;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalCost;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn Status;
    }
}