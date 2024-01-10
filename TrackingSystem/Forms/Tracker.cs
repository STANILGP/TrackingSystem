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
using TrackingSystem.Forms;
using TrackingSystem.Storage;

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
        public Storagee _storage;
        
        public Tracker(Storagee storagee)
        {
            InitializeComponent();
            _baseHelper = new DataBaseHelper();
            _storage = storagee;
        }

        private void AddTaskbutton_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
        }

        private void WorkCardbutton_Click(object sender, EventArgs e)
        {
            WorkCardForm workCard = new WorkCardForm(_storage);
            workCard.Show();

        }
    }
}
