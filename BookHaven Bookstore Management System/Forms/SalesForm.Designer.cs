namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class SalesForm
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
            cmbSelectBooks = new ComboBox();
            lblSelectBooks = new Label();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            btnCalculate = new Button();
            btnReceipt = new Button();
            numericUpDown1 = new NumericUpDown();
            btnAddToCart = new Button();
            dataGridViewCart = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblTotalCost = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // cmbSelectBooks
            // 
            cmbSelectBooks.FormattingEnabled = true;
            cmbSelectBooks.Location = new Point(78, 80);
            cmbSelectBooks.Name = "cmbSelectBooks";
            cmbSelectBooks.Size = new Size(270, 28);
            cmbSelectBooks.TabIndex = 0;
            // 
            // lblSelectBooks
            // 
            lblSelectBooks.AutoSize = true;
            lblSelectBooks.Location = new Point(78, 44);
            lblSelectBooks.Name = "lblSelectBooks";
            lblSelectBooks.Size = new Size(93, 20);
            lblSelectBooks.TabIndex = 1;
            lblSelectBooks.Text = "Select Books";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(78, 157);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(270, 27);
            txtDiscount.TabIndex = 4;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(78, 125);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Discount";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(520, 71);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(266, 45);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(520, 127);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(266, 45);
            btnReceipt.TabIndex = 7;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(371, 80);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 27);
            numericUpDown1.TabIndex = 9;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(520, 188);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(266, 45);
            btnAddToCart.TabIndex = 10;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { BookID, Title, Quantity, Price, Total });
            dataGridViewCart.Location = new Point(189, 292);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(539, 228);
            dataGridViewCart.TabIndex = 11;
            // 
            // BookID
            // 
            BookID.HeaderText = "BookID";
            BookID.MinimumWidth = 6;
            BookID.Name = "BookID";
            BookID.ReadOnly = true;
            BookID.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(78, 213);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(75, 20);
            lblTotalCost.TabIndex = 12;
            lblTotalCost.Text = "Total Cost";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 546);
            Controls.Add(lblTotalCost);
            Controls.Add(dataGridViewCart);
            Controls.Add(btnAddToCart);
            Controls.Add(numericUpDown1);
            Controls.Add(btnReceipt);
            Controls.Add(btnCalculate);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblSelectBooks);
            Controls.Add(cmbSelectBooks);
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSelectBooks;
        private Label lblSelectBooks;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Button btnCalculate;
        private Button btnReceipt;
        private NumericUpDown numericUpDown1;
        private Button btnAddToCart;
        private DataGridView dataGridViewCart;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Total;
        private Label lblTotalCost;
    }
}