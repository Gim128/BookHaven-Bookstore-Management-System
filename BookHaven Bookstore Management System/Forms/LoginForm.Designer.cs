namespace BookHaven_Bookstore_Management_System.Forms
{
    partial class LoginForm
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
            lblUsername = new Label();
            lblPassword = new Label();
            cmbRole = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole1 = new ComboBox();
            btnLogin = new Button();
            lblLoginPage = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(185, 150);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            lblUsername.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(185, 207);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.Click += label1_Click_1;
            // 
            // cmbRole
            // 
            cmbRole.AutoSize = true;
            cmbRole.Location = new Point(194, 256);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(39, 20);
            cmbRole.TabIndex = 2;
            cmbRole.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(283, 147);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(360, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(283, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 4;
            // 
            // cmbRole1
            // 
            cmbRole1.FormattingEnabled = true;
            cmbRole1.Location = new Point(283, 248);
            cmbRole1.Name = "cmbRole1";
            cmbRole1.Size = new Size(360, 28);
            cmbRole1.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(283, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(301, 61);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login Here";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblLoginPage
            // 
            lblLoginPage.AutoSize = true;
            lblLoginPage.Location = new Point(379, 61);
            lblLoginPage.Name = "lblLoginPage";
            lblLoginPage.Size = new Size(90, 20);
            lblLoginPage.TabIndex = 7;
            lblLoginPage.Text = "LOGIN PAGE";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLoginPage);
            Controls.Add(btnLogin);
            Controls.Add(cmbRole1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(cmbRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label cmbRole;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole1;
        private Button btnLogin;
        private Label lblLoginPage;
    }
}