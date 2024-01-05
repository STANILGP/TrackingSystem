using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace TrackingSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Uni\ООP\TrackingSystem\TrackingSystem\Database\Database1.mdf;Integrated Security=True";
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string Query;
        DataTable datatable;
        SqlDataAdapter sqladapter;
        DataView gridDataSourse;
        int ID = 1000;

        private void SUBMIT_button_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text != "" && PasswordTextBox.Text != "" && NameTextBox.Text != "" && LastNameTextBox.Text!=""&& RoleTextBox.Text!="")
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Insert INTO [Employee] (username,password,name,lastname,role) VALUES (@username,@password,@name,@lastname,@role)";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlcommand.Parameters.AddWithValue("@username", UserNameTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@name", NameTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@lastname", LastNameTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@role", RoleTextBox.Text);
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
           
        }

        private void UserNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(UserNameTextBox.Text, "\\S"))
            {
                errorProvider1.SetError(UserNameTextBox, "Enter a name");
            }
            else
            {
                errorProvider1.SetError(UserNameTextBox, "");
            }
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(PasswordTextBox.Text, "\\S"))
            {
                errorProvider1.SetError(PasswordTextBox, "Enter a password");
            }
            else
            {
                errorProvider1.SetError(PasswordTextBox, "");
            }
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(NameTextBox.Text, "\\S"))
            {
                errorProvider1.SetError(NameTextBox, "Enter a password");
            }
            else
            {
                errorProvider1.SetError(NameTextBox, "");
            }
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(LastNameTextBox.Text, "\\S"))
            {
                errorProvider1.SetError(LastNameTextBox, "Enter a password");
            }
            else
            {
                errorProvider1.SetError(LastNameTextBox, "");
            }
        }

        private void RoleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(RoleTextBox.Text, "\\S"))
            {
                errorProvider1.SetError(RoleTextBox, "Enter a password");
            }
            else
            {
                errorProvider1.SetError(RoleTextBox, "");
            }
        }
    }
}
