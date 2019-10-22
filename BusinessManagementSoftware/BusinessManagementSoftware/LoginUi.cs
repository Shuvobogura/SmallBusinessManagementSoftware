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

namespace BusinessManagementSoftware
{
    public partial class LoginUi : Form
    {
        public LoginUi()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNameTextBox.Text))
            {
                //passwoedLabel.Visible = false;
                userLabel.Text = "User can not be empty";
                userNameTextBox.Focus();
                return;
            }
            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                userLabel.Visible = false;
                passwoedLabel.Text = "Password can not be empty";
                passwordTextBox.Focus();
                return;
            }

            LogIn();
        }

        //Login Method
        public void LogIn()
        {
            string connectionString = @"SERVER=DESKTOP-BDF5EPV; DATABASE=BusinessManagementSystemDb; INTEGRATED SECURITY=true";
            SqlConnection sqlConnection=new SqlConnection(connectionString);
            string commandString = @"SELECT * FROM LogIn WHERE Name = '"+userNameTextBox.Text+"' AND Password = '"+passwordTextBox.Text+"'";
            SqlCommand sqlCommand=new  SqlCommand(commandString,sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sqlCommand);
            DataTable dataTable=new  DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count==1)
            {
                this.Hide();
                ProductUi productUi=new ProductUi();
                productUi.Show();
            }
            else
            {
                MessageBox.Show("Please Check User Name or Password");
            }

            sqlConnection.Close();
        }
    }
}
