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

    public partial class FrmPass2 : Form
    {

        public FrmPass2()
        {
            InitializeComponent();
        }

        private void lblNewPass_Click(object sender, EventArgs e)
        {

        }

        private void FrmPass2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtNewPass2.Text)
            {
                MessageBox.Show("Your password does not matched");
            }
            else
            {
                //SqlCommand command;
                string User = txtUser.Text;
                string Pass = txtNewPass.Text;
                if (CheckCredentials(User))
                {
                    this.Hide();
                    FrmLogin2 frmLogin2 = new FrmLogin2();
                    frmLogin2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Doesn't exits");
                }
            }
            }
        private bool CheckCredentials(string username)
        {
            string User = txtUser.Text;
            string Pass = txtNewPass.Text;
            string connectionString = @"Data Source=.;Initial Catalog=University; Integrated Security=true; 
                            User ID=;Password=;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                string query = "UPDATE [dbo].[Users] Set Password='" + Pass + "'Where Username='" + User + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                adapter.UpdateCommand = new SqlCommand(query, connection);
                adapter.UpdateCommand.ExecuteNonQuery();

                //int count = (int)command.ExecuteScalar();

                
                command.Dispose();
                connection.Close();
                return true;
            }

        }
    
    }
}
