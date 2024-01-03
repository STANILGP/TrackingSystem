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
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.database1DataSet.Task);
            // TODO: This line of code loads data into the 'database1DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet.Employee);

        }

        
    }
}
