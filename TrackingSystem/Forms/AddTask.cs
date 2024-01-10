using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingSystem.Services;

namespace TrackingSystem.Forms
{
    public partial class AddTask : Form
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
        public AddTask()
        {
            InitializeComponent();
            _baseHelper = new DataBaseHelper();
        }

        private void AddTaskbutton_Click(object sender, EventArgs e)
        {
            if (DayOfStartdateTimePicker.Value != DateTime.MinValue && DayOfEnddateTimePicker.Value != DateTime.MinValue && TaskName_textBox.Text != "" && Owner_comboBox.SelectedItem != null && Employee_comboBox.SelectedItem != null && Status_comboBox.SelectedItem != null && NeededHours_textbox.Text != "" && Summary_richTextBox2.Text != "")
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Insert INTO [Task] (name,summary,dayofstart,dayofend,id_owner,id_employee,allhour,hourNow,status) VALUES (@name,@summary,@dayofstart,@dayofend,@id_owner,@id_employee,@allhour,@hourNow,@status)";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlcommand.Parameters.AddWithValue("@name", TaskName_textBox.Text);
                sqlcommand.Parameters.AddWithValue("@summary", Summary_richTextBox2.Text);
                sqlcommand.Parameters.AddWithValue("@dayofstart", DayOfStartdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@dayofend", DayOfEnddateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@id_owner", _baseHelper.SearchForIDEmployee(Owner_comboBox.Text, sqlconnection, sqlcommand));
                sqlcommand.Parameters.AddWithValue("@id_employee", _baseHelper.SearchForIDEmployee(Employee_comboBox.Text, sqlconnection, sqlcommand));
                sqlcommand.Parameters.AddWithValue("@allhour", NeededHours_textbox.Text);
                sqlcommand.Parameters.AddWithValue("@hourNow", NowHourstextBox.Text);
                sqlcommand.Parameters.AddWithValue("@status", Status_comboBox.Text);
                if (sqlcommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Insert successfully!");
                    sqlconnection.Close();
                    this.Close();
                }
            }
            
        }

       
    }
}
