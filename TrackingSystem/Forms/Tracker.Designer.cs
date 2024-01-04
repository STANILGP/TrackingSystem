namespace TrackingSystem
{
    partial class Tracker
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TaskTab = new System.Windows.Forms.TabPage();
            this.NextButton = new System.Windows.Forms.Button();
            this.Prevbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.AddTaskTab = new System.Windows.Forms.TabPage();
            this.Employee_comboBox = new System.Windows.Forms.ComboBox();
            this.Owner_comboBox = new System.Windows.Forms.ComboBox();
            this.AddTaskbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Summary_richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Status_comboBox = new System.Windows.Forms.ComboBox();
            this.NowHour_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.WarkCardTab = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.Donebutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EndTaskdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTaskdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Summary_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TaskcomboBox = new System.Windows.Forms.ComboBox();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new TrackingSystem.Database1DataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TrackingSystem.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new TrackingSystem.Database1DataSetTableAdapters.TaskTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.TaskTab.SuspendLayout();
            this.AddTaskTab.SuspendLayout();
            this.WarkCardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tabControl1.Controls.Add(this.TaskTab);
            this.tabControl1.Controls.Add(this.AddTaskTab);
            this.tabControl1.Controls.Add(this.WarkCardTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseWaitCursor = true;
            this.tabControl1.Visible = false;
            // 
            // TaskTab
            // 
            this.TaskTab.Controls.Add(this.NextButton);
            this.TaskTab.Controls.Add(this.Prevbutton);
            this.TaskTab.Controls.Add(this.tableLayoutPanel1);
            this.TaskTab.Controls.Add(this.textBox1);
            this.TaskTab.Controls.Add(this.Searchbutton);
            this.TaskTab.Location = new System.Drawing.Point(4, 25);
            this.TaskTab.Name = "TaskTab";
            this.TaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.TaskTab.Size = new System.Drawing.Size(792, 375);
            this.TaskTab.TabIndex = 0;
            this.TaskTab.Text = "Tasks";
            this.TaskTab.UseVisualStyleBackColor = true;
            this.TaskTab.UseWaitCursor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(463, 333);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.UseWaitCursor = true;
            // 
            // Prevbutton
            // 
            this.Prevbutton.Location = new System.Drawing.Point(300, 333);
            this.Prevbutton.Name = "Prevbutton";
            this.Prevbutton.Size = new System.Drawing.Size(75, 23);
            this.Prevbutton.TabIndex = 3;
            this.Prevbutton.Text = "Prev";
            this.Prevbutton.UseVisualStyleBackColor = true;
            this.Prevbutton.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 76);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 240);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseWaitCursor = true;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(479, 31);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 0;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.UseWaitCursor = true;
            // 
            // AddTaskTab
            // 
            this.AddTaskTab.Controls.Add(this.Employee_comboBox);
            this.AddTaskTab.Controls.Add(this.Owner_comboBox);
            this.AddTaskTab.Controls.Add(this.AddTaskbutton);
            this.AddTaskTab.Controls.Add(this.label9);
            this.AddTaskTab.Controls.Add(this.Summary_richTextBox2);
            this.AddTaskTab.Controls.Add(this.Status_comboBox);
            this.AddTaskTab.Controls.Add(this.NowHour_textBox);
            this.AddTaskTab.Controls.Add(this.label7);
            this.AddTaskTab.Controls.Add(this.label6);
            this.AddTaskTab.Controls.Add(this.label5);
            this.AddTaskTab.Controls.Add(this.label4);
            this.AddTaskTab.Controls.Add(this.label3);
            this.AddTaskTab.Controls.Add(this.label2);
            this.AddTaskTab.Controls.Add(this.DayOfEnddateTimePicker);
            this.AddTaskTab.Controls.Add(this.DayOfStartdateTimePicker);
            this.AddTaskTab.Controls.Add(this.label1);
            this.AddTaskTab.Controls.Add(this.NeededHours_textbox);
            this.AddTaskTab.Controls.Add(this.TaskName_textBox);
            this.AddTaskTab.Controls.Add(this.label8);
            this.AddTaskTab.Location = new System.Drawing.Point(4, 25);
            this.AddTaskTab.Name = "AddTaskTab";
            this.AddTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTaskTab.Size = new System.Drawing.Size(792, 375);
            this.AddTaskTab.TabIndex = 1;
            this.AddTaskTab.Text = "Add Task";
            this.AddTaskTab.UseVisualStyleBackColor = true;
            this.AddTaskTab.UseWaitCursor = true;
            // 
            // Employee_comboBox
            // 
            this.Employee_comboBox.FormattingEnabled = true;
            this.Employee_comboBox.Location = new System.Drawing.Point(122, 132);
            this.Employee_comboBox.Name = "Employee_comboBox";
            this.Employee_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Employee_comboBox.TabIndex = 20;
            this.Employee_comboBox.UseWaitCursor = true;
            this.Employee_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.Employee_comboBox_Validating);
            // 
            // Owner_comboBox
            // 
            this.Owner_comboBox.FormattingEnabled = true;
            this.Owner_comboBox.Location = new System.Drawing.Point(122, 90);
            this.Owner_comboBox.Name = "Owner_comboBox";
            this.Owner_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Owner_comboBox.TabIndex = 19;
            this.Owner_comboBox.UseWaitCursor = true;
            this.Owner_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.Owner_comboBox_Validating);
            // 
            // AddTaskbutton
            // 
            this.AddTaskbutton.Location = new System.Drawing.Point(298, 310);
            this.AddTaskbutton.Name = "AddTaskbutton";
            this.AddTaskbutton.Size = new System.Drawing.Size(147, 23);
            this.AddTaskbutton.TabIndex = 18;
            this.AddTaskbutton.Text = "ADD TASK";
            this.AddTaskbutton.UseVisualStyleBackColor = true;
            this.AddTaskbutton.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Summary";
            this.label9.UseWaitCursor = true;
            // 
            // Summary_richTextBox2
            // 
            this.Summary_richTextBox2.Location = new System.Drawing.Point(381, 190);
            this.Summary_richTextBox2.Name = "Summary_richTextBox2";
            this.Summary_richTextBox2.Size = new System.Drawing.Size(228, 92);
            this.Summary_richTextBox2.TabIndex = 16;
            this.Summary_richTextBox2.Text = "";
            this.Summary_richTextBox2.UseWaitCursor = true;
            this.Summary_richTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.Summary_richTextBox2_Validating);
            // 
            // Status_comboBox
            // 
            this.Status_comboBox.FormattingEnabled = true;
            this.Status_comboBox.Items.AddRange(new object[] {
            "NEW",
            "STARTED",
            "ENDED",
            "CANSELED"});
            this.Status_comboBox.Location = new System.Drawing.Point(101, 242);
            this.Status_comboBox.Name = "Status_comboBox";
            this.Status_comboBox.Size = new System.Drawing.Size(121, 24);
            this.Status_comboBox.TabIndex = 14;
            this.Status_comboBox.UseWaitCursor = true;
            this.Status_comboBox.Validating += new System.ComponentModel.CancelEventHandler(this.Status_comboBox_Validating);
            // 
            // NowHour_textBox
            // 
            this.NowHour_textBox.Location = new System.Drawing.Point(122, 205);
            this.NowHour_textBox.Name = "NowHour_textBox";
            this.NowHour_textBox.Size = new System.Drawing.Size(37, 22);
            this.NowHour_textBox.TabIndex = 13;
            this.NowHour_textBox.UseWaitCursor = true;
            this.NowHour_textBox.TextChanged += new System.EventHandler(this.NowHour_textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Now Hour";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Needed Hours";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Emloyee";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Day of Start";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Day of end";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Owner";
            this.label2.UseWaitCursor = true;
            // 
            // DayOfEnddateTimePicker
            // 
            this.DayOfEnddateTimePicker.Location = new System.Drawing.Point(381, 131);
            this.DayOfEnddateTimePicker.Name = "DayOfEnddateTimePicker";
            this.DayOfEnddateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DayOfEnddateTimePicker.TabIndex = 6;
            this.DayOfEnddateTimePicker.UseWaitCursor = true;
            this.DayOfEnddateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DayOfEnddateTimePicker_Validating);
            // 
            // DayOfStartdateTimePicker
            // 
            this.DayOfStartdateTimePicker.Location = new System.Drawing.Point(381, 82);
            this.DayOfStartdateTimePicker.Name = "DayOfStartdateTimePicker";
            this.DayOfStartdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.DayOfStartdateTimePicker.TabIndex = 5;
            this.DayOfStartdateTimePicker.UseWaitCursor = true;
            this.DayOfStartdateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.DayOfStartdateTimePicker_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Name";
            this.label1.UseWaitCursor = true;
            // 
            // NeededHours_textbox
            // 
            this.NeededHours_textbox.Location = new System.Drawing.Point(149, 169);
            this.NeededHours_textbox.Name = "NeededHours_textbox";
            this.NeededHours_textbox.Size = new System.Drawing.Size(35, 22);
            this.NeededHours_textbox.TabIndex = 3;
            this.NeededHours_textbox.UseWaitCursor = true;
            this.NeededHours_textbox.Validating += new System.ComponentModel.CancelEventHandler(this.NeededHours_textbox_Validating);
            // 
            // TaskName_textBox
            // 
            this.TaskName_textBox.Location = new System.Drawing.Point(122, 44);
            this.TaskName_textBox.Name = "TaskName_textBox";
            this.TaskName_textBox.Size = new System.Drawing.Size(100, 22);
            this.TaskName_textBox.TabIndex = 0;
            this.TaskName_textBox.UseWaitCursor = true;
            this.TaskName_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.TaskName_textBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status";
            this.label8.UseWaitCursor = true;
            // 
            // WarkCardTab
            // 
            this.WarkCardTab.Controls.Add(this.label13);
            this.WarkCardTab.Controls.Add(this.Donebutton);
            this.WarkCardTab.Controls.Add(this.label12);
            this.WarkCardTab.Controls.Add(this.label11);
            this.WarkCardTab.Controls.Add(this.EndTaskdateTimePicker);
            this.WarkCardTab.Controls.Add(this.StartTaskdateTimePicker);
            this.WarkCardTab.Controls.Add(this.Summary_richTextBox);
            this.WarkCardTab.Controls.Add(this.label10);
            this.WarkCardTab.Controls.Add(this.TaskcomboBox);
            this.WarkCardTab.Location = new System.Drawing.Point(4, 25);
            this.WarkCardTab.Name = "WarkCardTab";
            this.WarkCardTab.Size = new System.Drawing.Size(792, 375);
            this.WarkCardTab.TabIndex = 2;
            this.WarkCardTab.Text = "WorkCard";
            this.WarkCardTab.UseVisualStyleBackColor = true;
            this.WarkCardTab.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Summary";
            this.label13.UseWaitCursor = true;
            // 
            // Donebutton
            // 
            this.Donebutton.Location = new System.Drawing.Point(312, 278);
            this.Donebutton.Name = "Donebutton";
            this.Donebutton.Size = new System.Drawing.Size(75, 23);
            this.Donebutton.TabIndex = 7;
            this.Donebutton.Text = "DONE";
            this.Donebutton.UseVisualStyleBackColor = true;
            this.Donebutton.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "End Task";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "Start Task";
            this.label11.UseWaitCursor = true;
            // 
            // EndTaskdateTimePicker
            // 
            this.EndTaskdateTimePicker.Location = new System.Drawing.Point(41, 143);
            this.EndTaskdateTimePicker.Name = "EndTaskdateTimePicker";
            this.EndTaskdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.EndTaskdateTimePicker.TabIndex = 4;
            this.EndTaskdateTimePicker.UseWaitCursor = true;
            this.EndTaskdateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.EndTaskdateTimePicker_Validating);
            // 
            // StartTaskdateTimePicker
            // 
            this.StartTaskdateTimePicker.Location = new System.Drawing.Point(41, 93);
            this.StartTaskdateTimePicker.Name = "StartTaskdateTimePicker";
            this.StartTaskdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.StartTaskdateTimePicker.TabIndex = 3;
            this.StartTaskdateTimePicker.UseWaitCursor = true;
            this.StartTaskdateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.StartTaskdateTimePicker_Validating);
            // 
            // Summary_richTextBox
            // 
            this.Summary_richTextBox.Location = new System.Drawing.Point(376, 116);
            this.Summary_richTextBox.Name = "Summary_richTextBox";
            this.Summary_richTextBox.Size = new System.Drawing.Size(316, 100);
            this.Summary_richTextBox.TabIndex = 2;
            this.Summary_richTextBox.Text = "";
            this.Summary_richTextBox.UseWaitCursor = true;
            this.Summary_richTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.Summary_richTextBox_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Task";
            this.label10.UseWaitCursor = true;
            // 
            // TaskcomboBox
            // 
            this.TaskcomboBox.FormattingEnabled = true;
            this.TaskcomboBox.Location = new System.Drawing.Point(86, 192);
            this.TaskcomboBox.Name = "TaskcomboBox";
            this.TaskcomboBox.Size = new System.Drawing.Size(155, 24);
            this.TaskcomboBox.TabIndex = 0;
            this.TaskcomboBox.UseWaitCursor = true;
            this.TaskcomboBox.Validating += new System.ComponentModel.CancelEventHandler(this.TaskcomboBox_Validating);
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tracker";
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Tracker_Load);
            this.tabControl1.ResumeLayout(false);
            this.TaskTab.ResumeLayout(false);
            this.TaskTab.PerformLayout();
            this.AddTaskTab.ResumeLayout(false);
            this.AddTaskTab.PerformLayout();
            this.WarkCardTab.ResumeLayout(false);
            this.WarkCardTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TaskTab;
        private System.Windows.Forms.TabPage AddTaskTab;
        private System.Windows.Forms.TabPage WarkCardTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Database1DataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox NeededHours_textbox;
        private System.Windows.Forms.TextBox TaskName_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DayOfEnddateTimePicker;
        private System.Windows.Forms.DateTimePicker DayOfStartdateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Status_comboBox;
        private System.Windows.Forms.TextBox NowHour_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Summary_richTextBox2;
        private System.Windows.Forms.RichTextBox Summary_richTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TaskcomboBox;
        private System.Windows.Forms.Button AddTaskbutton;
        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker EndTaskdateTimePicker;
        private System.Windows.Forms.DateTimePicker StartTaskdateTimePicker;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button Prevbutton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Employee_comboBox;
        private System.Windows.Forms.ComboBox Owner_comboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}