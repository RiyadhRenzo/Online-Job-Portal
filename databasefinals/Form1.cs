using MySql.Data.MySqlClient;

namespace databasefinals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void AdminEnter_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.Show();
            this.Hide();
        }

        private void GuestEnter_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }
    }
}
