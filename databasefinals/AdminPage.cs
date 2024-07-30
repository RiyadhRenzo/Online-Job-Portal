using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace databasefinals
{
    public partial class AdminPage : Form
    {
        string mysqlCon = "server=127.0.0.1; port=3307; user=root; database=itep finals;";
        MySqlConnection mySqlConnection;
        public AdminPage()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
            LoadDataIntoDataGridView();
            LoadApplicantDATA();
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                string query = "SELECT * FROM Jobs";

                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AdminPage_Load(object sender, EventArgs e)
        {

        }//EMPTY

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                txtJobID.Text = selectedRow.Cells["JobID"].Value.ToString();
                txtJobName.Text = selectedRow.Cells["JobName"].Value.ToString();
                txtLocation.Text = selectedRow.Cells["Location"].Value.ToString();
                txtCredentials.Text = selectedRow.Cells["CredentialsNeeded"].Value.ToString();
                txtSalary.Text = selectedRow.Cells["Salary"].Value.ToString();
            }

        }

        private void JobSearchAdmin_Click(object sender, EventArgs e)//SEARCH BUTTON FOR JOBS
        {
            string searchCriteria = txtSearch.Text.Trim();

            string searchQuery = $"SELECT * FROM Jobs WHERE JobName LIKE '%{searchCriteria}%' OR Location LIKE '%{searchCriteria}%' OR CredentialsNeeded LIKE '%{searchCriteria}%' OR Salary LIKE '%{searchCriteria}%'";

            try
            {
                using (MySqlCommand command = new MySqlCommand(searchQuery, mySqlConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddNewJob(string jobName, string location, string credentialsNeeded, decimal salary)
        {
            try
            {
                string query = "INSERT INTO Jobs (JobName, Location, CredentialsNeeded, Salary) VALUES (@JobName, @Location, @CredentialsNeeded, @Salary)";
                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@JobName", jobName);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@CredentialsNeeded", credentialsNeeded);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddJob_Click(object sender, EventArgs e)
        {
            string jobName = txtJobName.Text;
            string location = txtLocation.Text;
            string credentialsNeeded = txtCredentials.Text;
            decimal salary = Convert.ToDecimal(txtSalary.Text);

            AddNewJob(jobName, location, credentialsNeeded, salary);

        }
        private void EditCurrentJob(int jobId, string jobName, string location, string credentialsNeeded, decimal salary)
        {
            try
            {
                string query = "UPDATE Jobs SET JobName = @JobName, Location = @Location, CredentialsNeeded = @CredentialsNeeded, Salary = @Salary WHERE JobID = @JobID";
                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@JobID", jobId);
                    command.Parameters.AddWithValue("@JobName", jobName);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@CredentialsNeeded", credentialsNeeded);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void EditJob_Click(object sender, EventArgs e)
        {
            int jobId = Convert.ToInt32(txtJobID.Text);
            string jobName = txtJobName.Text;
            string location = txtLocation.Text;
            string credentialsNeeded = txtCredentials.Text;
            decimal salary = Convert.ToDecimal(txtSalary.Text);

            EditCurrentJob(jobId, jobName, location, credentialsNeeded, salary);
        }
        private void DeleteExistingJob(int jobId)
        {
            try
            {
                string query = "DELETE FROM Jobs WHERE JobID = @JobID";
                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@JobID", jobId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DeleteJob_Click(object sender, EventArgs e)
        {
            int jobId = Convert.ToInt32(txtJobID.Text);
            DeleteExistingJob(jobId);

        }

        private void salarylabel_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow2 = dataGridView2.SelectedRows[0];

                txtApplicantID.Text = selectedRow2.Cells["ApplicantID"].Value.ToString();
                txtApplicantName.Text = selectedRow2.Cells["Name"].Value.ToString();
                txtApplicantAge.Text = selectedRow2.Cells["Age"].Value.ToString();
                txtApplicantEmail.Text = selectedRow2.Cells["Email"].Value.ToString();
                txtContact.Text = selectedRow2.Cells["ContactNumber"].Value.ToString();
                txtEducation.Text = selectedRow2.Cells["EducationalLevel"].Value.ToString();
                txtExp.Text = selectedRow2.Cells["WorkExperience"].Value.ToString();
                txtPrevious.Text = selectedRow2.Cells["PreviousWork"].Value.ToString();
                txtStatus.Text = selectedRow2.Cells["Status"].Value.ToString();
            }


        }
        private void LoadApplicantDATA()
        {
            string applicantQuery = "SELECT ApplicantID, Name, Age, Email, ContactNumber, EducationalLevel, WorkExperience, PreviousWork, Status FROM Applicant";

            MySqlCommand applicantCommand = new MySqlCommand(applicantQuery, mySqlConnection);
            MySqlDataAdapter applicantAdapter = new MySqlDataAdapter(applicantCommand);

            DataTable applicantDataTable = new DataTable();
            applicantAdapter.Fill(applicantDataTable);

            dataGridView2.DataSource = applicantDataTable;
            dataGridView2.Refresh();

        }
        private void ApplicantSearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = ApplicantSearch.Text.Trim();

            string searchQuery = $"SELECT * FROM Applicant WHERE Name LIKE '%{searchCriteria}%' OR Age LIKE '%{searchCriteria}%' OR Email LIKE '%{searchCriteria}%' OR ContactNumber LIKE '%{searchCriteria}%' OR EducationalLevel LIKE '%{searchCriteria}%' OR WorkExperience LIKE '%{searchCriteria}%' OR PreviousWork LIKE '%{searchCriteria}%'";

            try
            {
                using (MySqlCommand command = new MySqlCommand(searchQuery, mySqlConnection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void button4_Click(object sender, EventArgs e)//REMOVE
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int applicantIDToDelete = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ApplicantID"].Value);
                string query = "DELETE FROM Applicants WHERE ApplicantID = @ApplicantID";

                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@ApplicantID", applicantIDToDelete);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Applicant removed successfully.");
                        LoadApplicantDATA();
                    }
                    else
                    {
                        MessageBox.Show("No applicant found or unable to remove.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an applicant to remove.");
            }

        }

        private void button3_Click(object sender, EventArgs e)//PLACE UNDER REVIEW
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string applicantName = selectedRow.Cells["Name"].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to {applicantName} under review?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int applicantID = Convert.ToInt32(selectedRow.Cells["ApplicantID"].Value);
                    string query = "UPDATE Applicant SET Status = 'Under Review' WHERE ApplicantID = @ApplicantID";
                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@ApplicantID", applicantID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Applicant is now placed under review.");
                            // Refresh the DataGridView to reflect the changes
                            LoadApplicantDATA();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an applicant to hire.");
            }

        }
        private void button2_Click(object sender, EventArgs e)//REJECT
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string applicantName = selectedRow.Cells["Name"].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to reject {applicantName}?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int applicantID = Convert.ToInt32(selectedRow.Cells["ApplicantID"].Value);
                    string query = "UPDATE Applicant SET Status = 'Rejected' WHERE ApplicantID = @ApplicantID";
                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@ApplicantID", applicantID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Applicant rejected successfully.");
                            // Refresh the DataGridView to reflect the changes
                            LoadApplicantDATA();
                        }
                        else
                        {
                            MessageBox.Show("Failed to reject applicant.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an applicant to hire.");
            }
        }

        private void button1_Click(object sender, EventArgs e)//HIRE
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Get the name of the selected applicant
                string applicantName = selectedRow.Cells["Name"].Value.ToString();

                // Display a confirmation MessageBox
                DialogResult result = MessageBox.Show($"Are you sure you want to hire {applicantName}?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    // Get the ID of the selected applicant
                    int applicantID = Convert.ToInt32(selectedRow.Cells["ApplicantID"].Value);

                    // Update the status of the applicant to "Hired" in the database
                    string query = "UPDATE Applicant SET Status = 'Hired' WHERE ApplicantID = @ApplicantID";
                    using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@ApplicantID", applicantID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Applicant hired successfully.");
                            // Refresh the DataGridView to reflect the changes
                            LoadApplicantDATA();
                        }
                        else
                        {
                            MessageBox.Show("Failed to hire applicant.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an applicant to hire.");
            }
        }

    }
}
