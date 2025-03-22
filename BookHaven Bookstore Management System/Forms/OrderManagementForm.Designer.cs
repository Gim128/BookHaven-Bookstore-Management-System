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
            cmbBooks = new ComboBox();
            lblBooks = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            cmbDeliveryOption = new ComboBox();
            lblDeliveryOption = new Label();
            numQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // cmbSelectCustomers
            // 
            cmbSelectCustomers.FormattingEnabled = true;
            cmbSelectCustomers.Location = new Point(61, 76);
            cmbSelectCustomers.Name = "cmbSelectCustomers";
            cmbSelectCustomers.Size = new Size(168, 28);
            cmbSelectCustomers.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(848, 272);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(181, 45);
            btnPlaceOrder.TabIndex = 1;
            btnPlaceOrder.Text = "PlaceOrder";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(848, 341);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(182, 47);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnTrackOrder
            // 
            btnTrackOrder.Location = new Point(848, 413);
            btnTrackOrder.Name = "btnTrackOrder";
            btnTrackOrder.Size = new Size(181, 47);
            btnTrackOrder.TabIndex = 3;
            btnTrackOrder.Text = "Track Order";
            btnTrackOrder.UseVisualStyleBackColor = true;
            btnTrackOrder.Click += btnTrackOrder_Click;
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
            dataGridViewOrder.Location = new Point(15, 240);
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
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(265, 74);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(181, 28);
            cmbBooks.TabIndex = 6;
            // 
            // lblBooks
            // 
            lblBooks.AutoSize = true;
            lblBooks.Location = new Point(265, 42);
            lblBooks.Name = "lblBooks";
            lblBooks.Size = new Size(49, 20);
            lblBooks.TabIndex = 7;
            lblBooks.Text = "Books";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(620, 76);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(181, 28);
            cmbStatus.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(620, 42);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Status";
            // 
            // cmbDeliveryOption
            // 
            cmbDeliveryOption.FormattingEnabled = true;
            cmbDeliveryOption.Location = new Point(61, 150);
            cmbDeliveryOption.Name = "cmbDeliveryOption";
            cmbDeliveryOption.Size = new Size(181, 28);
            cmbDeliveryOption.TabIndex = 10;
            // 
            // lblDeliveryOption
            // 
            lblDeliveryOption.AutoSize = true;
            lblDeliveryOption.Location = new Point(61, 127);
            lblDeliveryOption.Name = "lblDeliveryOption";
            lblDeliveryOption.Size = new Size(113, 20);
            lblDeliveryOption.TabIndex = 11;
            lblDeliveryOption.Text = "Delivery Option";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(461, 74);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(78, 27);
            numQuantity.TabIndex = 12;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 537);
            Controls.Add(numQuantity);
            Controls.Add(lblDeliveryOption);
            Controls.Add(cmbDeliveryOption);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblBooks);
            Controls.Add(cmbBooks);
            Controls.Add(dataGridViewOrder);
            Controls.Add(label1);
            Controls.Add(btnTrackOrder);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnPlaceOrder);
            Controls.Add(cmbSelectCustomers);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
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
        private ComboBox cmbBooks;
        private Label lblBooks;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private ComboBox cmbDeliveryOption;
        private Label lblDeliveryOption;
        private NumericUpDown numQuantity;
    }
}