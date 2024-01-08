using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using TrackingSystem.Services;

namespace TrackingSystem
{
    public partial class Tracker : Form
    {
        private DataBaseHelper _baseHelper;
        string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Desktop\Uni\ООP\TrackingSystem\TrackingSystem\Database\Database1.mdf;Integrated Security=True";
        SqlConnection sqlconnection;
        SqlCommand sqlcommand;
        string Query;
        DataTable datatable;
        SqlDataAdapter sqladapter;
        DataView gridDataSourse;
        int WorkCardID = 10000;
        
        public Tracker()
        {
            InitializeComponent();
            _baseHelper = new DataBaseHelper();
        }


        private void StartTaskdateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (StartTaskdateTimePicker.Value == DateTime.MinValue)
            {
                errorProvider1.SetError(StartTaskdateTimePicker, "Enter Date and time");
            }
        }

        private void EndTaskdateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (EndTaskdateTimePicker.Value == DateTime.MinValue)
            {
                errorProvider1.SetError(EndTaskdateTimePicker, "Enter Date and time");
            }
        }

        private void DayOfStartdateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if(DayOfStartdateTimePicker.Value == DateTime.MinValue) 
            {
                errorProvider1.SetError(DayOfStartdateTimePicker, "Enter Date and time");
            }
        }

        private void DayOfEnddateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            if (DayOfEnddateTimePicker.Value == DateTime.MinValue)
            {
                errorProvider1.SetError(DayOfEnddateTimePicker, "Enter Date and time");
            }
        }

        private void Summary_richTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (Summary_richTextBox.Text.Length < 10)
            {
                errorProvider1.SetError(Summary_richTextBox, "Enter summary");   
            }
        }

        private void TaskcomboBox_Validating(object sender, CancelEventArgs e)
        {
            if(TaskcomboBox.SelectedItem == null)
            {
                errorProvider1.SetError(TaskcomboBox, "Choise a Task");
            }
        }

        private void Owner_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (Owner_comboBox.SelectedItem == null)
            {
                errorProvider1.SetError(Owner_comboBox, "Choise a Owner");
            }
        }

        private void Employee_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (Employee_comboBox.SelectedItem == null)
            {
                errorProvider1.SetError(Employee_comboBox, "Choise a Employee");
            }
        }

        private void TaskName_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (TaskName_textBox.Text == "")
            {
                errorProvider1.SetError(TaskName_textBox, "Enter a name");
            }
        }

        private void NeededHours_textbox_Validating(object sender, CancelEventArgs e)
        {
            if (NeededHours_textbox.Text == "")
            {
                errorProvider1.SetError(NeededHours_textbox, "Enter a hour");
            }
        }

        private void Status_comboBox_Validating(object sender, CancelEventArgs e)
        {
            if (Status_comboBox.SelectedItem == null)
            {
                errorProvider1.SetError(Status_comboBox, "Choise a Status");
            }
        }

        private void Summary_richTextBox2_Validating(object sender, CancelEventArgs e)
        {
            if (Summary_richTextBox2.Text.Length < 10)
            {
                errorProvider1.SetError(Summary_richTextBox2, "Enter summary");
            }
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            if (StartTaskdateTimePicker.Value!=DateTime.MinValue && EndTaskdateTimePicker.Value!=DateTime.MinValue && TaskcomboBox.SelectedItem!=null&& Summary_richTextBox.Text!="")
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Insert INTO [WorkCard] (startOfAction,endOfAction,id_Task,discription,id_Employee) VALUES (@startOfAction,@endOfAction,@id_Task,@discription,@id_Employee)";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlcommand.Parameters.AddWithValue("@startOfAction", StartTaskdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@endOfAction", EndTaskdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@id_Task", _baseHelper.SearchForIDTask(TaskcomboBox.Text, sqlconnection, sqlcommand));
                sqlcommand.Parameters.AddWithValue("@discription", Summary_richTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@id_Employee", _baseHelper.SearchForIDEmployee(Employee_comboBox.Text, sqlconnection, sqlcommand));
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Insert successfully!");
            }
        }

        private void AddTaskbutton_Click(object sender, EventArgs e)
        {
            if (DayOfStartdateTimePicker.Value != DateTime.MinValue && DayOfEnddateTimePicker.Value != DateTime.MinValue && TaskName_textBox.Text != "" && Owner_comboBox.SelectedItem != null && Employee_comboBox.SelectedItem != null && Status_comboBox.SelectedItem != null && NeededHours_textbox.Text != "" && Summary_richTextBox2.Text != "")
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Insert INTO [Task] (name,summary,dayofstart,dayofend,id_owner,id_employee,allhour,hourNow,id_status) VALUES (@name,@summary,@dayofstart,@dayofend,@id_owner,@id_employee,@allhour,@hourNow,@id_status)";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlcommand.Parameters.AddWithValue("@name",TaskName_textBox.Text);
                sqlcommand.Parameters.AddWithValue("@summary",Summary_richTextBox2.Text);
                sqlcommand.Parameters.AddWithValue("@dayofstart",DayOfStartdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@dayofend",DayOfEnddateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@id_owner",_baseHelper.SearchForIDEmployee(Owner_comboBox.Text,sqlconnection,sqlcommand));
                sqlcommand.Parameters.AddWithValue("@id_employee", _baseHelper.SearchForIDEmployee(Employee_comboBox.Text, sqlconnection, sqlcommand));
                sqlcommand.Parameters.AddWithValue("@allhour",NeededHours_textbox.Text);
                sqlcommand.Parameters.AddWithValue("@hourNow", NowHourstextBox.Text);
                sqlcommand.Parameters.AddWithValue("id_status",Status_comboBox.SelectedIndex);
            }
        }

        private void NowHourstextBox_Validating(object sender, CancelEventArgs e)
        {
            if (NowHourstextBox.Text == "")
            {
                errorProvider1.SetError(NowHourstextBox, "Enter a hour");
            }
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
        }
    }
}
