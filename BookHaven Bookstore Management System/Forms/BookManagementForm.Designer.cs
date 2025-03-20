namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class BookManagementForm
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblISBN = new Label();
            lblPrice = new Label();
            textBox5 = new TextBox();
            lblStockQuantity = new Label();
            textBox6 = new TextBox();
            lblBookManagement = new Label();
            dataGridViewBooks = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(133, 88);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(382, 88);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(662, 88);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(662, 114);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 27);
            textBox4.TabIndex = 6;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(133, 177);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 7;
            lblISBN.Text = "ISBN";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(382, 177);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Price";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(382, 204);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 27);
            textBox5.TabIndex = 8;
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(662, 177);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(105, 20);
            lblStockQuantity.TabIndex = 11;
            lblStockQuantity.Text = "Stock Quantity";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(662, 204);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 27);
            textBox6.TabIndex = 10;
            // 
            // lblBookManagement
            // 
            lblBookManagement.AutoSize = true;
            lblBookManagement.Location = new Point(430, 26);
            lblBookManagement.Name = "lblBookManagement";
            lblBookManagement.Size = new Size(135, 20);
            lblBookManagement.TabIndex = 12;
            lblBookManagement.Text = "Book Management";
            lblBookManagement.Click += label1_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { BookID, Title, Author, Genre, ISBN, Price, StockQuantity });
            dataGridViewBooks.Dock = DockStyle.Bottom;
            dataGridViewBooks.Location = new Point(0, 288);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.Size = new Size(988, 264);
            dataGridViewBooks.TabIndex = 13;
            dataGridViewBooks.CellContentClick += dataGridView1_CellContentClick_1;
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
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.MinimumWidth = 6;
            Genre.Name = "Genre";
            Genre.Width = 125;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // StockQuantity
            // 
            StockQuantity.HeaderText = "StockQuantity";
            StockQuantity.MinimumWidth = 6;
            StockQuantity.Name = "StockQuantity";
            StockQuantity.Width = 125;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 552);
            Controls.Add(dataGridViewBooks);
            Controls.Add(lblBookManagement);
            Controls.Add(lblStockQuantity);
            Controls.Add(textBox6);
            Controls.Add(lblPrice);
            Controls.Add(textBox5);
            Controls.Add(lblISBN);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Name = "BookManagementForm";
            Text = "BookManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblISBN;
        private Label lblPrice;
        private TextBox textBox5;
        private Label lblStockQuantity;
        private TextBox textBox6;
        private Label lblBookManagement;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn StockQuantity;
    }
}