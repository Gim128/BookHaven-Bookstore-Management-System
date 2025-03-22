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
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            txtDiscount = new TextBox();
            lblDiscount = new Label();
            btnCalculate = new Button();
            btnReceipt = new Button();
            dataGridViewCart = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
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
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(78, 141);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(78, 168);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(270, 27);
            txtQuantity.TabIndex = 3;
            txtQuantity.TextChanged += textBox1_TextChanged;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(78, 261);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(270, 27);
            txtDiscount.TabIndex = 4;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(78, 229);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Discount";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(78, 323);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(266, 45);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(78, 386);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(266, 45);
            btnReceipt.TabIndex = 7;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { BookID, Title, Price });
            dataGridViewCart.Location = new Point(569, 61);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersWidth = 51;
            dataGridViewCart.Size = new Size(428, 386);
            dataGridViewCart.TabIndex = 8;
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
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 546);
            Controls.Add(dataGridViewCart);
            Controls.Add(btnReceipt);
            Controls.Add(btnCalculate);
            Controls.Add(lblDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(lblSelectBooks);
            Controls.Add(cmbSelectBooks);
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSelectBooks;
        private Label lblSelectBooks;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private TextBox txtDiscount;
        private Label lblDiscount;
        private Button btnCalculate;
        private Button btnReceipt;
        private DataGridView dataGridViewCart;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Price;
    }
}