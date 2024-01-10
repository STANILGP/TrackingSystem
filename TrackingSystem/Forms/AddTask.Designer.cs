namespace TrackingSystem.Forms
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NowHourstextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Employee_comboBox = new System.Windows.Forms.ComboBox();
            this.Owner_comboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Summary_richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Status_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DayOfEnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DayOfStartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NeededHours_textbox = new System.Windows.Forms.TextBox();
            this.TaskName_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddTaskbutton = new System.Windows.Forms.Button();
            this.database1DataSet = new TrackingSystem.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new TrackingSystem.Database1DataSet1();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TrackingSystem.Database1DataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NowHourstextBox
            // 
            this.NowHourstextBox.Location = new System.Drawing.Point(247, 200);
            this.NowHourstextBox.Name = "NowHourstextBox";
            this.NowHourstextBox.Size = new System.Drawing.Size(46, 22);
            this.NowHourstextBox.TabIndex = 40;
            this.NowHourstextBox.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Hour to The moment";
            this.label7.UseWaitCursor = true;
            // 
            // Employee_comboBox
            // 
            this.Employee_comboBox.DataSource = this.employeeBindingSource;
            this.Employee_comboBox.DisplayMember = "UserName";
            this.Employee_comboBox.FormattingEnabled = true;
            this.Employee_comboBox.Location = new System.Drawing.Point(193, 135);
            this.Employee_comboBox.Name = "Employee_comboBox";
            this.Employee_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Employee_comboBox.TabIndex = 38;
            this.Employee_comboBox.UseWaitCursor = true;
            this.Employee_comboBox.ValueMember = "Name";
            // 
            // Owner_comboBox
            // 
            this.Owner_comboBox.DataSource = this.employeeBindingSource;
            this.Owner_comboBox.DisplayMember = "UserName";
            this.Owner_comboBox.FormattingEnabled = true;
            this.Owner_comboBox.Location = new System.Drawing.Point(193, 93);
            this.Owner_comboBox.Name = "Owner_comboBox";
            this.Owner_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Owner_comboBox.TabIndex = 37;
            this.Owner_comboBox.UseWaitCursor = true;
            this.Owner_comboBox.ValueMember = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Summary";
            this.label9.UseWaitCursor = true;
            // 
            // Summary_richTextBox2
            // 
            this.Summary_richTextBox2.Location = new System.Drawing.Point(452, 193);
            this.Summary_richTextBox2.Name = "Summary_richTextBox2";
            this.Summary_richTextBox2.Size = new System.Drawing.Size(228, 92);
            this.Summary_richTextBox2.TabIndex = 35;
            this.Summary_richTextBox2.Text = "";
            this.Summary_richTextBox2.UseWaitCursor = true;
            // 
            // Status_comboBox
            // 
            this.Status_comboBox.FormattingEnabled = true;
            this.Status_comboBox.Items.AddRange(new object[] {
            "NEW",
            "STARTED",
            "ENDED",
            "CANSELED"});
            this.Status_comboBox.Location = new System.Drawing.Point(172, 250);
            this.Status_comboBox.Name = "Status_comboBox";
            this.Status_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Status_comboBox.TabIndex = 33;
            this.Status_comboBox.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Needed Hours";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Emloyee";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Day of Start";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Day of end";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Owner";
            this.label2.UseWaitCursor = true;
            // 
            // DayOfEnddateTimePicker
            // 
            this.DayOfEnddateTimePicker.Location = new System.Drawing.Point(452, 134);
            this.DayOfEnddateTimePicker.Name = "DayOfEnddateTimePicker";
            this.DayOfEnddateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DayOfEnddateTimePicker.TabIndex = 27;
            this.DayOfEnddateTimePicker.UseWaitCursor = true;
            // 
            // DayOfStartdateTimePicker
            // 
            this.DayOfStartdateTimePicker.Location = new System.Drawing.Point(452, 85);
            this.DayOfStartdateTimePicker.Name = "DayOfStartdateTimePicker";
            this.DayOfStartdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DayOfStartdateTimePicker.TabIndex = 26;
            this.DayOfStartdateTimePicker.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Task Name";
            this.label1.UseWaitCursor = true;
            // 
            // NeededHours_textbox
            // 
            this.NeededHours_textbox.Location = new System.Drawing.Point(220, 172);
            this.NeededHours_textbox.Name = "NeededHours_textbox";
            this.NeededHours_textbox.Size = new System.Drawing.Size(35, 22);
            this.NeededHours_textbox.TabIndex = 24;
            this.NeededHours_textbox.UseWaitCursor = true;
            // 
            // TaskName_textBox
            // 
            this.TaskName_textBox.Location = new System.Drawing.Point(193, 47);
            this.TaskName_textBox.Name = "TaskName_textBox";
            this.TaskName_textBox.Size = new System.Drawing.Size(100, 22);
            this.TaskName_textBox.TabIndex = 23;
            this.TaskName_textBox.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "Status";
            this.label8.UseWaitCursor = true;
            // 
            // AddTaskbutton
            // 
            this.AddTaskbutton.Location = new System.Drawing.Point(329, 333);
            this.AddTaskbutton.Name = "AddTaskbutton";
            this.AddTaskbutton.Size = new System.Drawing.Size(147, 23);
            this.AddTaskbutton.TabIndex = 41;
            this.AddTaskbutton.Text = "ADD TASK";
            this.AddTaskbutton.UseVisualStyleBackColor = true;
            this.AddTaskbutton.UseWaitCursor = true;
            this.AddTaskbutton.Click += new System.EventHandler(this.AddTaskbutton_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database1DataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTaskbutton);
            this.Controls.Add(this.NowHourstextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Employee_comboBox);
            this.Controls.Add(this.Owner_comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Summary_richTextBox2);
            this.Controls.Add(this.Status_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DayOfEnddateTimePicker);
            this.Controls.Add(this.DayOfStartdateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NeededHours_textbox);
            this.Controls.Add(this.TaskName_textBox);
            this.Controls.Add(this.label8);
            this.Name = "AddTask";
            this.Text = "AddTask";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NowHourstextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Employee_comboBox;
        private System.Windows.Forms.ComboBox Owner_comboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Summary_richTextBox2;
        private System.Windows.Forms.ComboBox Status_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DayOfEnddateTimePicker;
        private System.Windows.Forms.DateTimePicker DayOfStartdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NeededHours_textbox;
        private System.Windows.Forms.TextBox TaskName_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddTaskbutton;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}