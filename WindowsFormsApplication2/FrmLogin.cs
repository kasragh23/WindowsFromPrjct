using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class FrmLogin : Form
    { 
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                FrmRegister frmRegister = new FrmRegister();
                this.Hide();
                frmRegister.ShowDialog();
                this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckCredentials(txtUser.Text, txtPass.Text))
            {
                FrmMain frmMain = new FrmMain(txtUser.Text);
                this.Hide();
                frmMain.ShowDialog();
                this.Close();     
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        static bool CheckCredentials(string username, string password)
        {
            string connectionString = @"Data Source=.;Initial Catalog=University; Integrated Security=true; 
                            User ID=;Password=;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
    


        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmPass frmPass = new FrmPass();
            frmPass.ShowDialog();
            this.Close();
        }
    }
}
