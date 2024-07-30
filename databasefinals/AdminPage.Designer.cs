namespace databasefinals
{
    partial class AdminPage
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtJobID = new TextBox();
            salarylabel = new Label();
            txtSalary = new TextBox();
            label3 = new Label();
            txtCredentials = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtLocation = new TextBox();
            txtJobName = new TextBox();
            DeleteJob = new Button();
            EditJob = new Button();
            AddJob = new Button();
            JobSearchAdmin = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            txtStatus = new TextBox();
            label13 = new Label();
            Remove = new Button();
            txtApplicantID = new TextBox();
            txtPrevious = new TextBox();
            txtExp = new TextBox();
            txtEducation = new TextBox();
            txtContact = new TextBox();
            label12 = new Label();
            label10 = new Label();
            txtApplicantEmail = new TextBox();
            label9 = new Label();
            Review = new Button();
            label8 = new Label();
            txtApplicantAge = new TextBox();
            label7 = new Label();
            Reject = new Button();
            txtApplicantName = new TextBox();
            Hire = new Button();
            label6 = new Label();
            ApplicantSearch = new Button();
            label5 = new Label();
            txtSearchApplicant = new TextBox();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtJobID);
            groupBox1.Controls.Add(salarylabel);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCredentials);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(txtJobName);
            groupBox1.Controls.Add(DeleteJob);
            groupBox1.Controls.Add(EditJob);
            groupBox1.Controls.Add(AddJob);
            groupBox1.Controls.Add(JobSearchAdmin);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1406, 468);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage Available Jobs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1140, 14);
            label4.Name = "label4";
            label4.Size = new Size(88, 31);
            label4.TabIndex = 14;
            label4.Text = "Job ID:";
            // 
            // txtJobID
            // 
            txtJobID.Location = new Point(1140, 48);
            txtJobID.Name = "txtJobID";
            txtJobID.Size = new Size(253, 38);
            txtJobID.TabIndex = 13;
            // 
            // salarylabel
            // 
            salarylabel.AutoSize = true;
            salarylabel.Location = new Point(1142, 321);
            salarylabel.Name = "salarylabel";
            salarylabel.Size = new Size(86, 31);
            salarylabel.TabIndex = 12;
            salarylabel.Text = "Salary:";
            salarylabel.Click += salarylabel_Click;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(1140, 355);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(253, 38);
            txtSalary.TabIndex = 11;
            txtSalary.TextChanged += txtSalary_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1142, 244);
            label3.Name = "label3";
            label3.Size = new Size(228, 31);
            label3.TabIndex = 10;
            label3.Text = "Credentials Needed:";
            // 
            // txtCredentials
            // 
            txtCredentials.Location = new Point(1142, 278);
            txtCredentials.Name = "txtCredentials";
            txtCredentials.Size = new Size(253, 38);
            txtCredentials.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1142, 164);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 8;
            label2.Text = "Location:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1142, 89);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 7;
            label1.Text = "Job Name:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(1142, 198);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(253, 38);
            txtLocation.TabIndex = 6;
            // 
            // txtJobName
            // 
            txtJobName.Location = new Point(1142, 123);
            txtJobName.Name = "txtJobName";
            txtJobName.Size = new Size(253, 38);
            txtJobName.TabIndex = 5;
            // 
            // DeleteJob
            // 
            DeleteJob.BackColor = SystemColors.ControlLight;
            DeleteJob.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            DeleteJob.Location = new Point(887, 381);
            DeleteJob.Name = "DeleteJob";
            DeleteJob.Size = new Size(247, 70);
            DeleteJob.TabIndex = 4;
            DeleteJob.Text = "Remove Job";
            DeleteJob.UseVisualStyleBackColor = false;
            DeleteJob.Click += DeleteJob_Click;
            // 
            // EditJob
            // 
            EditJob.BackColor = SystemColors.ControlLight;
            EditJob.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            EditJob.Location = new Point(469, 381);
            EditJob.Name = "EditJob";
            EditJob.Size = new Size(247, 70);
            EditJob.TabIndex = 3;
            EditJob.Text = "Edit Current Jobs";
            EditJob.UseVisualStyleBackColor = false;
            EditJob.Click += EditJob_Click;
            // 
            // AddJob
            // 
            AddJob.BackColor = SystemColors.ControlLight;
            AddJob.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            AddJob.Location = new Point(12, 381);
            AddJob.Name = "AddJob";
            AddJob.Size = new Size(247, 70);
            AddJob.TabIndex = 1;
            AddJob.Text = "Add New Job";
            AddJob.UseVisualStyleBackColor = false;
            AddJob.Click += AddJob_Click;
            // 
            // JobSearchAdmin
            // 
            JobSearchAdmin.BackColor = SystemColors.ControlLight;
            JobSearchAdmin.Location = new Point(689, 34);
            JobSearchAdmin.Name = "JobSearchAdmin";
            JobSearchAdmin.Size = new Size(112, 34);
            JobSearchAdmin.TabIndex = 2;
            JobSearchAdmin.Text = "Search";
            JobSearchAdmin.UseVisualStyleBackColor = false;
            JobSearchAdmin.Click += JobSearchAdmin_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(5, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(678, 38);
            txtSearch.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1129, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtStatus);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(Remove);
            groupBox2.Controls.Add(txtApplicantID);
            groupBox2.Controls.Add(txtPrevious);
            groupBox2.Controls.Add(txtExp);
            groupBox2.Controls.Add(txtEducation);
            groupBox2.Controls.Add(txtContact);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtApplicantEmail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(Review);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtApplicantAge);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(Reject);
            groupBox2.Controls.Add(txtApplicantName);
            groupBox2.Controls.Add(Hire);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(ApplicantSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSearchApplicant);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 483);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1406, 584);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Applicants List";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(1081, 538);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(278, 38);
            txtStatus.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label13.Location = new Point(927, 538);
            label13.Name = "label13";
            label13.Size = new Size(134, 25);
            label13.TabIndex = 31;
            label13.Text = "Current Status";
            // 
            // Remove
            // 
            Remove.BackColor = SystemColors.ControlLight;
            Remove.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Remove.Location = new Point(1142, 319);
            Remove.Name = "Remove";
            Remove.Size = new Size(238, 70);
            Remove.TabIndex = 30;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += button4_Click;
            // 
            // txtApplicantID
            // 
            txtApplicantID.Location = new Point(1081, 456);
            txtApplicantID.Name = "txtApplicantID";
            txtApplicantID.Size = new Size(278, 38);
            txtApplicantID.TabIndex = 29;
            // 
            // txtPrevious
            // 
            txtPrevious.Location = new Point(1081, 395);
            txtPrevious.Name = "txtPrevious";
            txtPrevious.Size = new Size(278, 38);
            txtPrevious.TabIndex = 28;
            // 
            // txtExp
            // 
            txtExp.Location = new Point(591, 538);
            txtExp.Name = "txtExp";
            txtExp.Size = new Size(303, 38);
            txtExp.TabIndex = 27;
            // 
            // txtEducation
            // 
            txtEducation.Location = new Point(591, 464);
            txtEducation.Name = "txtEducation";
            txtEducation.Size = new Size(303, 38);
            txtEducation.TabIndex = 26;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(591, 395);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(303, 38);
            txtContact.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label12.Location = new Point(927, 464);
            label12.Name = "label12";
            label12.Size = new Size(118, 25);
            label12.TabIndex = 24;
            label12.Text = "Applicant ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label10.Location = new Point(927, 405);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 18;
            label10.Text = "Previous Work";
            // 
            // txtApplicantEmail
            // 
            txtApplicantEmail.Location = new Point(76, 538);
            txtApplicantEmail.Name = "txtApplicantEmail";
            txtApplicantEmail.Size = new Size(306, 38);
            txtApplicantEmail.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label9.Location = new Point(409, 538);
            label9.Name = "label9";
            label9.Size = new Size(156, 25);
            label9.TabIndex = 17;
            label9.Text = "Work Experience";
            // 
            // Review
            // 
            Review.BackColor = SystemColors.ControlLight;
            Review.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Review.Location = new Point(722, 319);
            Review.Name = "Review";
            Review.Size = new Size(289, 70);
            Review.TabIndex = 17;
            Review.Text = "Place Under Review";
            Review.UseVisualStyleBackColor = false;
            Review.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label8.Location = new Point(413, 464);
            label8.Name = "label8";
            label8.Size = new Size(146, 25);
            label8.TabIndex = 16;
            label8.Text = "Education Level";
            // 
            // txtApplicantAge
            // 
            txtApplicantAge.Location = new Point(76, 464);
            txtApplicantAge.Name = "txtApplicantAge";
            txtApplicantAge.Size = new Size(306, 38);
            txtApplicantAge.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label7.Location = new Point(413, 392);
            label7.Name = "label7";
            label7.Size = new Size(152, 25);
            label7.TabIndex = 15;
            label7.Text = "Contact Number";
            // 
            // Reject
            // 
            Reject.BackColor = SystemColors.ControlLight;
            Reject.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Reject.Location = new Point(366, 319);
            Reject.Name = "Reject";
            Reject.Size = new Size(247, 70);
            Reject.TabIndex = 16;
            Reject.Text = "Reject";
            Reject.UseVisualStyleBackColor = false;
            Reject.Click += button2_Click;
            // 
            // txtApplicantName
            // 
            txtApplicantName.Location = new Point(76, 392);
            txtApplicantName.Name = "txtApplicantName";
            txtApplicantName.Size = new Size(306, 38);
            txtApplicantName.TabIndex = 21;
            // 
            // Hire
            // 
            Hire.BackColor = SystemColors.ControlLight;
            Hire.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Hire.Location = new Point(12, 319);
            Hire.Name = "Hire";
            Hire.Size = new Size(247, 70);
            Hire.TabIndex = 15;
            Hire.Text = "Hire";
            Hire.UseVisualStyleBackColor = false;
            Hire.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label6.Location = new Point(12, 538);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // ApplicantSearch
            // 
            ApplicantSearch.BackColor = SystemColors.ControlLight;
            ApplicantSearch.Location = new Point(689, 41);
            ApplicantSearch.Name = "ApplicantSearch";
            ApplicantSearch.Size = new Size(112, 34);
            ApplicantSearch.TabIndex = 15;
            ApplicantSearch.Text = "Search";
            ApplicantSearch.UseVisualStyleBackColor = false;
            ApplicantSearch.Click += ApplicantSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label5.Location = new Point(12, 464);
            label5.Name = "label5";
            label5.Size = new Size(46, 25);
            label5.TabIndex = 19;
            label5.Text = "Age";
            // 
            // txtSearchApplicant
            // 
            txtSearchApplicant.Location = new Point(0, 37);
            txtSearchApplicant.Name = "txtSearchApplicant";
            txtSearchApplicant.Size = new Size(683, 38);
            txtSearchApplicant.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            label11.Location = new Point(12, 395);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 18;
            label11.Text = "Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 81);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1397, 237);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 1061);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminPage";
            Text = "AdminPage";
            Load += AdminPage_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button JobSearchAdmin;
        private TextBox txtSearch;
        private Button DeleteJob;
        private Button EditJob;
        private Button AddJob;
        private TextBox txtJobName;
        private Label salarylabel;
        private TextBox txtSalary;
        private Label label3;
        private TextBox txtCredentials;
        private Label label2;
        private Label label1;
        private TextBox txtLocation;
        private Label label4;
        private TextBox txtJobID;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private TextBox txtSearchApplicant;
        private Button ApplicantSearch;
        private Button Reject;
        private Button Hire;
        private Button Review;
        private TextBox txtApplicantEmail;
        private TextBox txtApplicantAge;
        private TextBox txtApplicantName;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtExp;
        private TextBox txtEducation;
        private TextBox txtContact;
        private TextBox txtApplicantID;
        private TextBox txtPrevious;
        private Button Remove;
        private TextBox txtStatus;
        private Label label13;
    }
}