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
    public partial class FrmRegister : Form
    {
        SqlConnection cnn;
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void lblReg_Email_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpInterest_Enter(object sender, EventArgs e)
        {

        }

        private void lblEmptyName_Click(object sender, EventArgs e)
        {

        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtFamily.Text = "";
            txtEmail.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtPass2.Text = "";
            txtSecutiry.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*string Name = txtName.Text;
            string Family = txtFamily.Text;
            string Email = txtEmail.Text;
            string User = txtUser.Text;
            string Pass = txtPass.Text;
            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=.; Initial Catalog=Cinema; Integrated Security=true;
                        User ID=; Password=;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql, Output = "";

            sql = "Insert into Users (Uid, UName, UFamily, UEmail, Username, Password) Values(" + Name +
                ",'" + Family + ",'" + Email + ".'" + User + ",'" + Pass + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show(Output);
            command.Dispose();
            cnn.Close();*/
            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Your password does not matched");
            }
            else
            {
                User user = new User(txtName.Text, txtFamily.Text, txtUser.Text, txtPass.Text, txtFamily.Text);
                openDb();
                MessageBox.Show("connection open");
                SqlCommand command;
                String Name = txtName.Text;
                String Family = txtFamily.Text;
                String Email = txtEmail.Text;
                String User = txtUser.Text;
                String Pass = txtPass.Text;
                String Security = txtSecutiry.Text;
                String connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=.; Initial Catalog=University; Integrated Security=true;
                        User ID=; Password=;";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(); //for insertion , Deletion , Update
                string sql, Output = "";


                sql = "INSERT INTO [University].[dbo].[Users] (UName, UFamily, UEmail, Username, Password, Security) VALUES('" + Name +
                    "','" + Family + "','" + Email + "','" + User + "','" + Pass + "','" + Security +"')";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();



                MessageBox.Show(Output);
                command.Dispose();
                closeDb();

                FrmMain frmMain = new FrmMain(txtName.Text);
                this.Hide();
                frmMain.ShowDialog();
                this.Close();
            }
        }
        
        private void FrmRegister_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            string connectionString;

            connectionString = @"Data Source=.; Initial Catalog=University; Integrated Security=true;
                        User ID=; Password=;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //here should define queries for connect and read from sql
            SqlCommand command;
            SqlDataReader dataReader;
            //SqlDataAdapter adapter = new SqlDataAdapter(); //for insertion , Deletion , Update
            string sql, Output = "";

            sql = "SELECT Uid,UName FROM University.dbo.Users;";
            //sql = "INSERT INTO demotb (TutorialID, TutorialName) VALUES(3,'" + "VB.Net" + "')";
            command = new SqlCommand(sql, cnn);
            /*adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();*/

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);
            dataReader.Close();
            //command.Dispose();
            cnn.Close();
        }
        public void openDb()
        {
            string connectionString;
            //SqlConnection cnn;
            connectionString = @"Data Source=.; Initial Catalog=University; Integrated Security=true;
                        User ID=; Password=;";
            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }
        public void closeDb()
        {
            cnn.Close();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin2 frmLogin2 = new FrmLogin2();
            frmLogin2.ShowDialog();
            this.Close();
        }
    }

}
