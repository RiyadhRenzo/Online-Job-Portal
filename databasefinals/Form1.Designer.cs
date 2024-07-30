namespace databasefinals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GuestEnter = new Button();
            AdminEnter = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // GuestEnter
            // 
            GuestEnter.FlatStyle = FlatStyle.System;
            GuestEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            GuestEnter.Location = new Point(52, 295);
            GuestEnter.Name = "GuestEnter";
            GuestEnter.Size = new Size(112, 80);
            GuestEnter.TabIndex = 0;
            GuestEnter.Text = "Guest";
            GuestEnter.UseVisualStyleBackColor = true;
            GuestEnter.Click += GuestEnter_Click;
            // 
            // AdminEnter
            // 
            AdminEnter.FlatStyle = FlatStyle.System;
            AdminEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AdminEnter.Location = new Point(387, 295);
            AdminEnter.Name = "AdminEnter";
            AdminEnter.Size = new Size(112, 80);
            AdminEnter.TabIndex = 1;
            AdminEnter.Text = "Admin";
            AdminEnter.UseVisualStyleBackColor = true;
            AdminEnter.Click += AdminEnter_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(338, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 185);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(12, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 186);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 54);
            label1.TabIndex = 4;
            label1.Text = "Online Job Portal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(553, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(AdminEnter);
            Controls.Add(GuestEnter);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuestEnter;
        private Button AdminEnter;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
