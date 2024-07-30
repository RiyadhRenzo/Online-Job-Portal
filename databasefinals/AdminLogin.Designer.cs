namespace databasefinals
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label1 = new Label();
            txtPassword = new TextBox();
            Login = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(70, 225);
            label1.Name = "label1";
            label1.Size = new Size(367, 54);
            label1.TabIndex = 0;
            label1.Text = "Enter a Password: ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(70, 294);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(343, 31);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(168, 356);
            Login.Name = "Login";
            Login.Size = new Size(161, 82);
            Login.TabIndex = 2;
            Login.Text = "LOGIN";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(141, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 219);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Button Login;
        private PictureBox pictureBox1;
    }
}