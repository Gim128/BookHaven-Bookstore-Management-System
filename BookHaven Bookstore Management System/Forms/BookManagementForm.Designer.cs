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
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblISBN = new Label();
            lblStockQuantity = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtGenre = new TextBox();
            txtISBN = new TextBox();
            txtSTockQuantity = new TextBox();
            dataGridViewBook = new DataGridView();
            BookID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            StockQuantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(227, 267);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(129, 39);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(383, 267);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 39);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 267);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(695, 267);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(51, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            lblTitle.Click += label1_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(329, 45);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(71, 20);
            lblAuthor.TabIndex = 5;
            lblAuthor.Text = "lblAuthor";
            lblAuthor.Click += label2_Click;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(603, 45);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(879, 45);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 7;
            lblISBN.Text = "ISBN";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(51, 152);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(105, 20);
            lblStockQuantity.TabIndex = 8;
            lblStockQuantity.Text = "Stock Quantity";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(51, 90);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(194, 27);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(329, 90);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(194, 27);
            txtAuthor.TabIndex = 10;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(603, 90);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(194, 27);
            txtGenre.TabIndex = 11;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(879, 90);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(194, 27);
            txtISBN.TabIndex = 12;
            // 
            // txtSTockQuantity
            // 
            txtSTockQuantity.Location = new Point(51, 192);
            txtSTockQuantity.Name = "txtSTockQuantity";
            txtSTockQuantity.Size = new Size(194, 27);
            txtSTockQuantity.TabIndex = 13;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Columns.AddRange(new DataGridViewColumn[] { BookID, Title, Author, Genre, ISBN, Price, StockQuantity });
            dataGridViewBook.Location = new Point(95, 336);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.Size = new Size(927, 234);
            dataGridViewBook.TabIndex = 14;
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
            ClientSize = new Size(1129, 582);
            Controls.Add(dataGridViewBook);
            Controls.Add(txtSTockQuantity);
            Controls.Add(txtISBN);
            Controls.Add(txtGenre);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblStockQuantity);
            Controls.Add(lblISBN);
            Controls.Add(lblGenre);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Name = "BookManagementForm";
            Text = "BookManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblISBN;
        private Label lblStockQuantity;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtGenre;
        private TextBox txtISBN;
        private TextBox txtSTockQuantity;
        private DataGridView dataGridViewBook;
        private DataGridViewTextBoxColumn BookID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn StockQuantity;
    }
}