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
using TrackingSystem.Storage;

namespace TrackingSystem
{
    public partial class Login : Form
    {

        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Uni\ООP\TrackingSystem\TrackingSystem\Database\Database1.mdf;Integrated Security=True";
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string Query;
        DataTable datatable;
        SqlDataAdapter sqladapter;
        DataView gridDataSourse;
        public Storagee _storage;

        public Login()
        {
            InitializeComponent();
            _storage= new Storagee();
        }

        public void UserNameTextBoxLogin_Validating(object sender, CancelEventArgs e)
        {
            if (UserNameTextBoxLogin.Text == "")
            {
                errorProvider1.SetError(UserNameTextBoxLogin, "Enter a Username");
            }
        }

        public void PasswordTextBoxLogin_Validating(object sender, CancelEventArgs e)
        {
            if (PasswordTextBoxLogin.Text == "")
            {
                errorProvider1.SetError(PasswordTextBoxLogin, "Enter a password");
            }
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username, password;
            username= UserNameTextBoxLogin.Text;
            password= PasswordTextBoxLogin.Text;

            try
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Select * From Employee WHERE username= '" + UserNameTextBoxLogin.Text + "' AND password = '" + PasswordTextBoxLogin.Text + "'";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                using (SqlDataReader reader = sqlcommand.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int MyProfileId = reader.GetInt32(reader.GetOrdinal("ID"));
                            string MyProfileUserName = reader.GetString(reader.GetOrdinal("UserName"));
                            string MyProfilePassword = reader.GetString(reader.GetOrdinal("Password"));
                            string MyProfileName = reader.GetString(reader.GetOrdinal("Name"));
                            string MyProfileLastName = reader.GetString(reader.GetOrdinal("LastName"));
                            string MyProfileRole = reader.GetString(reader.GetOrdinal("Role"));
                            Employee myProfile = new Employee(MyProfileId, MyProfileUserName, MyProfilePassword, MyProfileName, MyProfileLastName, MyProfileRole);
                            _storage.SetMyProfile(myProfile);
                        }
                        Tracker tracker = new Tracker(_storage);
                        tracker.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password");
                    }
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
