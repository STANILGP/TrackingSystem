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

namespace TrackingSystem
{
    public partial class Tracker : Form
    {

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
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
           
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

        private void NowHour_textBox_TextChanged(object sender, EventArgs e)
        {
            if (NowHour_textBox.Text == "")
            {
                errorProvider1.SetError(NowHour_textBox, "Enter a hour");
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
            if (StartTaskdateTimePicker.Value!=DateTime.MinValue && EndTaskdateTimePicker.Value!=DateTime.MinValue && TaskcomboBox.SelectedItem!=null)
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Insert INTO [WorkCard] (startOfAction,endOfAction,id_Task,discription,id_Employee) VALUES (@startOfAction,@endOfAction,@id_Task,@discription,@id_Employee)";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlcommand.Parameters.AddWithValue("@startOfAction", StartTaskdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@endOfAction", EndTaskdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@id_Task", TaskcomboBox.SelectedItem);
                sqlcommand.Parameters.AddWithValue("@discription", Summary_richTextBox.Text);
               // sqlcommand.Parameters.AddWithValue("@id_Employee", );
                sqlcommand.ExecuteNonQuery();
                sqlconnection.Close();
                MessageBox.Show("Insert successfully!");
                WorkCardID++;
            }
            else
            {
               
            }
        }

        private void AddTaskbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
