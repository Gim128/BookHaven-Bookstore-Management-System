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
            lblusername = new Label();
            lblPassword = new Label();
            lblrole = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lblbtn = new Button();
            lbllogin = new Label();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(124, 133);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(82, 20);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(124, 181);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password :";
            // 
            // lblrole
            // 
            lblrole.AutoSize = true;
            lblrole.Location = new Point(124, 225);
            lblrole.Name = "lblrole";
            lblrole.Size = new Size(46, 20);
            lblrole.TabIndex = 2;
            lblrole.Text = "Role :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(222, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(222, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(222, 218);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(414, 27);
            textBox3.TabIndex = 5;
            // 
            // lblbtn
            // 
            lblbtn.Location = new Point(370, 292);
            lblbtn.Name = "lblbtn";
            lblbtn.Size = new Size(94, 29);
            lblbtn.TabIndex = 6;
            lblbtn.Text = "Login Here";
            lblbtn.UseVisualStyleBackColor = true;
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(369, 56);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(95, 20);
            lbllogin.TabIndex = 7;
            lbllogin.Text = "LOGIN FORM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbllogin);
            Controls.Add(lblbtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblrole);
            Controls.Add(lblPassword);
            Controls.Add(lblusername);
            Name = "Form1";
            Text = "LoginForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Label lblPassword;
        private Label lblrole;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button lblbtn;
        private Label lbllogin;
    }
}