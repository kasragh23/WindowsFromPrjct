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
    public partial class FrmPass : Form
    {
        SqlConnection cnn;
        public FrmPass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPass_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Security = txtSec.Text;
            if (CheckCredentials(Email,Security))
            {
                this.Hide();
                FrmPass2 frmPass2 = new FrmPass2();
                frmPass2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid answer. Please try again.");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private bool CheckCredentials(string email, string security)

        {
            string Email = txtEmail.Text;
            string Security = txtSec.Text;
            string connectionString = @"Data Source=.;Initial Catalog=University; Integrated Security=true; 
                            User ID=;Password=;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Security = '"+ Security +"' AND UEmail ='" +Email+"'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UEmail", email);
                command.Parameters.AddWithValue("@Secutiry", security);
                
                int count = (int)command.ExecuteScalar();

                return count > 0;
                connection.Close();
            }
        }
    }

       





    }


