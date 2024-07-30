using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databasefinals
{
    public partial class Jobs : Form
    {
        string mysqlCon = "server=127.0.0.1; port=3307; user=root; database=itep finals;";
        MySqlConnection mySqlConnection;
        public Jobs()
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
        private void LoadApplicantDATA()
        {
            string applicantQuery = "SELECT Name, Age, Email, ContactNumber, EducationalLevel, WorkExperience, PreviousWork FROM Applicant";

            MySqlCommand applicantCommand = new MySqlCommand(applicantQuery, mySqlConnection);
            MySqlDataAdapter applicantAdapter = new MySqlDataAdapter(applicantCommand);

            DataTable applicantDataTable = new DataTable();
            applicantAdapter.Fill(applicantDataTable);

            dataGridView2.DataSource = applicantDataTable;
            dataGridView2.Refresh();

        }

        private void Jobs_Load(object sender, EventArgs e)//EMPTY
        {

        }

        private void label1_Click(object sender, EventArgs e)//EMPTY
        {

        }

        private void label2_Click(object sender, EventArgs e)//EMPTY
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//SELECT DATABASE WHEN CLICKED TO ALLOW FOR APPLY
        {
            if (e.RowIndex >= 0 && (dataGridView1.Columns[e.ColumnIndex].Name == "JobID" || dataGridView1.Columns[e.ColumnIndex].Name == "JobName"))
            {
                // Select the entire row
                dataGridView1.Rows[e.RowIndex].Selected = true;

            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Applicant (Name, Age, Email, ContactNumber, EducationalLevel, WorkExperience, PreviousWork) " +
                           "VALUES (@Name, @Age, @Email, @ContactNumber, @EducationalLevel, @WorkExperience, @PreviousWork)";

            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@Name", nameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Age", int.Parse(ageTextBox.Text.Trim()));
                command.Parameters.AddWithValue("@Email", emailTextBox.Text.Trim());
                command.Parameters.AddWithValue("@ContactNumber", contactNumberTextBox.Text.Trim());
                command.Parameters.AddWithValue("@EducationalLevel", educationalLevelTextBox.Text.Trim());
                command.Parameters.AddWithValue("@WorkExperience", workExperienceTextBox.Text.Trim());
                command.Parameters.AddWithValue("@PreviousWork", previousWorkTextBox.Text.Trim());

                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data inserted successfully.");

                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ApplyFor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int jobId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["JobID"].Value);
                string jobName = dataGridView1.Rows[selectedRowIndex].Cells["JobName"].Value.ToString();

                try
                {
                    string updateQuery = "UPDATE Jobs SET NumberOfApplicants = NumberOfApplicants + 1 WHERE JobID = @JobID";
                    using (MySqlCommand command = new MySqlCommand(updateQuery, mySqlConnection))
                    {
                        command.Parameters.AddWithValue("@JobID", jobId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"You applied for '{jobName}'.");
                            dataGridView1.DataSource = null;
                            LoadDataIntoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update number of applicants.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a job to apply.");
            }
        }
        private int GetApplicantCount(int jobId)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Applications WHERE JobID = @JobID";
                using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
                {
                    command.Parameters.AddWithValue("@JobID", jobId);
                    int applicantCount = Convert.ToInt32(command.ExecuteScalar());
                    return applicantCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1; // Return -1 to indicate an error
            }
        }
       }
}
