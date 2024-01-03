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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.AddTaskTab = new System.Windows.Forms.TabPage();
            this.AddTaskbutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WarkCardTab = new System.Windows.Forms.TabPage();
            this.Donebutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.database1DataSet = new TrackingSystem.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new TrackingSystem.Database1DataSetTableAdapters.EmployeeTableAdapter();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new TrackingSystem.Database1DataSetTableAdapters.TaskTableAdapter();
            this.taskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taskBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.Prevbutton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TaskTab.SuspendLayout();
            this.AddTaskTab.SuspendLayout();
            this.WarkCardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource2)).BeginInit();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
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
            this.AddTaskTab.Controls.Add(this.AddTaskbutton);
            this.AddTaskTab.Controls.Add(this.label9);
            this.AddTaskTab.Controls.Add(this.richTextBox1);
            this.AddTaskTab.Controls.Add(this.comboBox1);
            this.AddTaskTab.Controls.Add(this.textBox6);
            this.AddTaskTab.Controls.Add(this.label7);
            this.AddTaskTab.Controls.Add(this.label6);
            this.AddTaskTab.Controls.Add(this.label5);
            this.AddTaskTab.Controls.Add(this.label4);
            this.AddTaskTab.Controls.Add(this.label3);
            this.AddTaskTab.Controls.Add(this.label2);
            this.AddTaskTab.Controls.Add(this.dateTimePicker2);
            this.AddTaskTab.Controls.Add(this.dateTimePicker1);
            this.AddTaskTab.Controls.Add(this.label1);
            this.AddTaskTab.Controls.Add(this.textBox5);
            this.AddTaskTab.Controls.Add(this.textBox4);
            this.AddTaskTab.Controls.Add(this.textBox3);
            this.AddTaskTab.Controls.Add(this.textBox2);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(381, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(228, 92);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.UseWaitCursor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(122, 205);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(37, 22);
            this.textBox6.TabIndex = 13;
            this.textBox6.UseWaitCursor = true;
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
            this.label6.Size = new System.Drawing.Size(160, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hour probably to be done";
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(381, 131);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(381, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.UseWaitCursor = true;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(200, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 22);
            this.textBox5.TabIndex = 3;
            this.textBox5.UseWaitCursor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseWaitCursor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.UseWaitCursor = true;
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
            this.WarkCardTab.Controls.Add(this.dateTimePicker4);
            this.WarkCardTab.Controls.Add(this.dateTimePicker3);
            this.WarkCardTab.Controls.Add(this.richTextBox2);
            this.WarkCardTab.Controls.Add(this.label10);
            this.WarkCardTab.Controls.Add(this.comboBox2);
            this.WarkCardTab.Location = new System.Drawing.Point(4, 25);
            this.WarkCardTab.Name = "WarkCardTab";
            this.WarkCardTab.Size = new System.Drawing.Size(792, 375);
            this.WarkCardTab.TabIndex = 2;
            this.WarkCardTab.Text = "WorkCard";
            this.WarkCardTab.UseVisualStyleBackColor = true;
            this.WarkCardTab.UseWaitCursor = true;
            // 
            // Donebutton
            // 
            this.Donebutton.Location = new System.Drawing.Point(376, 327);
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
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(41, 143);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 4;
            this.dateTimePicker4.UseWaitCursor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(41, 93);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 3;
            this.dateTimePicker3.UseWaitCursor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(376, 145);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(316, 100);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.UseWaitCursor = true;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 24);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.UseWaitCursor = true;
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
            // taskBindingSource1
            // 
            this.taskBindingSource1.DataMember = "Task";
            this.taskBindingSource1.DataSource = this.database1DataSetBindingSource;
            // 
            // taskBindingSource2
            // 
            this.taskBindingSource2.DataMember = "Task";
            this.taskBindingSource2.DataSource = this.database1DataSetBindingSource;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Summary";
            // 
            // Prevbutton
            // 
            this.Prevbutton.Location = new System.Drawing.Point(300, 333);
            this.Prevbutton.Name = "Prevbutton";
            this.Prevbutton.Size = new System.Drawing.Size(75, 23);
            this.Prevbutton.TabIndex = 3;
            this.Prevbutton.Text = "Prev";
            this.Prevbutton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(463, 333);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource taskBindingSource1;
        private System.Windows.Forms.BindingSource taskBindingSource2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button AddTaskbutton;
        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button Prevbutton;
        private System.Windows.Forms.Label label13;
    }
}