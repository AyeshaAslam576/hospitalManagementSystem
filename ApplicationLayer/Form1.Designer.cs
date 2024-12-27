namespace HopitalSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lbluser = new Label();
            lblPassword = new Label();
            txtuser = new TextBox();
            txtpassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(569, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(125, 47);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(399, 24);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(82, 20);
            lbluser.TabIndex = 1;
            lbluser.Text = "User Name";
            lbluser.Click += label1_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(399, 69);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            lblPassword.Click += label2_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(502, 21);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(192, 27);
            txtuser.TabIndex = 3;
            txtuser.TextChanged += textBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(502, 66);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(192, 27);
            txtpassword.TabIndex = 4;
            txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hospital2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1145, 642);
            Controls.Add(txtpassword);
            Controls.Add(txtuser);
            Controls.Add(lblPassword);
            Controls.Add(lbluser);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lbluser;
        private Label lblPassword;
        private TextBox txtuser;
        private TextBox txtpassword;
    }
}