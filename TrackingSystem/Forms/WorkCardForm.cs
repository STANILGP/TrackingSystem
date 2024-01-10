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
using TrackingSystem.Storage;

namespace TrackingSystem.Forms
{
    public partial class WorkCardForm : Form
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
        public Storagee _storage;
        public WorkCardForm(Storagee storage)
        {
            InitializeComponent();
            _baseHelper = new DataBaseHelper();
            _storage = storage;
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            if (StartTaskdateTimePicker.Value != DateTime.MinValue && EndTaskdateTimePicker.Value != DateTime.MinValue && TaskcomboBox.SelectedItem != null && Summary_richTextBox.Text != "")
            {
                sqlconnection = new SqlConnection(cs);
                sqlconnection.Open();
                Query = "Insert INTO [WorkCard] (startOfAction,endOfAction,id_Task,discription,id_Employee) VALUES (@startOfAction,@endOfAction,@id_Task,@discription,@id_Employee)";
                sqlcommand = new SqlCommand(Query, sqlconnection);
                sqlcommand.Parameters.AddWithValue("@startOfAction", StartTaskdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@endOfAction", EndTaskdateTimePicker.Value);
                sqlcommand.Parameters.AddWithValue("@id_Task", _baseHelper.SearchForIDTask(TaskcomboBox.Text, sqlconnection, sqlcommand));
                sqlcommand.Parameters.AddWithValue("@discription", Summary_richTextBox.Text);
                sqlcommand.Parameters.AddWithValue("@id_Employee", _storage.GetMyProfile().GetID());
                sqlcommand.ExecuteNonQuery();
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
