using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrackingSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SUBMIT_button_Click(object sender, EventArgs e)
        {

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
