using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackingSystem
{
    public partial class SINGIN : Form
    {
        public SINGIN()
        {
            InitializeComponent();
        }

        private void GO_TO_REGISTRATION_FORM_BUTTON_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void GO_TO_LOGIN_FORM_BUTTON_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
