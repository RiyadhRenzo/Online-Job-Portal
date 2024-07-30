namespace databasefinals
{
    partial class Jobs
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            SearchButton = new Button();
            groupBox1 = new GroupBox();
            previousWorkTextBox = new TextBox();
            workExperienceTextBox = new TextBox();
            educationalLevelTextBox = new TextBox();
            contactNumberTextBox = new TextBox();
            emailTextBox = new TextBox();
            ageTextBox = new TextBox();
            nameTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            Submit = new Button();
            ApplyFor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 41);
            label1.TabIndex = 0;
            label1.Text = "Find Jobs Here";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(710, 25);
            label2.TabIndex = 1;
            label2.Text = "You may search using specific names, location, level of education needed, or even salary.\r\n";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(869, 331);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 78);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(710, 31);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = SystemColors.ControlLight;
            SearchButton.BackgroundImageLayout = ImageLayout.Center;
            SearchButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SearchButton.Location = new Point(728, 75);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(112, 34);
            SearchButton.TabIndex = 4;
            SearchButton.Text = "SEARCH";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(previousWorkTextBox);
            groupBox1.Controls.Add(workExperienceTextBox);
            groupBox1.Controls.Add(educationalLevelTextBox);
            groupBox1.Controls.Add(contactNumberTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(ageTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            groupBox1.Location = new Point(887, -3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 539);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // previousWorkTextBox
            // 
            previousWorkTextBox.Location = new Point(6, 492);
            previousWorkTextBox.Name = "previousWorkTextBox";
            previousWorkTextBox.Size = new Size(210, 38);
            previousWorkTextBox.TabIndex = 8;
            // 
            // workExperienceTextBox
            // 
            workExperienceTextBox.Location = new Point(6, 431);
            workExperienceTextBox.Name = "workExperienceTextBox";
            workExperienceTextBox.Size = new Size(210, 38);
            workExperienceTextBox.TabIndex = 20;
            // 
            // educationalLevelTextBox
            // 
            educationalLevelTextBox.Location = new Point(6, 356);
            educationalLevelTextBox.Name = "educationalLevelTextBox";
            educationalLevelTextBox.Size = new Size(210, 38);
            educationalLevelTextBox.TabIndex = 19;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Location = new Point(6, 280);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(210, 38);
            contactNumberTextBox.TabIndex = 18;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(6, 205);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(210, 38);
            emailTextBox.TabIndex = 17;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(6, 131);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(210, 38);
            ageTextBox.TabIndex = 16;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(6, 59);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(210, 38);
            nameTextBox.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label10.Location = new Point(0, 470);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 14;
            label10.Text = "Previous Work";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label9.Location = new Point(0, 403);
            label9.Name = "label9";
            label9.Size = new Size(156, 25);
            label9.TabIndex = 13;
            label9.Text = "Work Experience";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label8.Location = new Point(6, 328);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 12;
            label8.Text = "Education Level";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(6, 252);
            label7.Name = "label7";
            label7.Size = new Size(152, 25);
            label7.TabIndex = 11;
            label7.Text = "Contact Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(6, 177);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 10;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label5.Location = new Point(6, 103);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 9;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label4.Location = new Point(6, 34);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 533);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1091, 218);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(12, 467);
            label3.Name = "label3";
            label3.Size = new Size(410, 41);
            label3.TabIndex = 7;
            label3.Text = "List of Other Job Applicants";
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.ControlLight;
            Submit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Submit.Location = new Point(728, 452);
            Submit.Name = "Submit";
            Submit.Size = new Size(153, 68);
            Submit.TabIndex = 8;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // ApplyFor
            // 
            ApplyFor.BackColor = SystemColors.ControlLight;
            ApplyFor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ApplyFor.Location = new Point(569, 452);
            ApplyFor.Name = "ApplyFor";
            ApplyFor.Size = new Size(153, 68);
            ApplyFor.TabIndex = 9;
            ApplyFor.Text = "Apply";
            ApplyFor.UseVisualStyleBackColor = false;
            ApplyFor.Click += ApplyFor_Click;
            // 
            // Jobs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 763);
            Controls.Add(ApplyFor);
            Controls.Add(Submit);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(SearchButton);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Jobs";
            Text = "Jobs";
            Load += Jobs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button SearchButton;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox workExperienceTextBox;
        private TextBox educationalLevelTextBox;
        private TextBox contactNumberTextBox;
        private TextBox emailTextBox;
        private TextBox ageTextBox;
        private TextBox nameTextBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox previousWorkTextBox;
        private Button Submit;
        private Button ApplyFor;
    }
}