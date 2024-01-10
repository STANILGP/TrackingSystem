namespace TrackingSystem.Forms
{
    partial class WorkCardForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.Donebutton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EndTaskdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTaskdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Summary_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TaskcomboBox = new System.Windows.Forms.ComboBox();
            this.database1DataSet2 = new TrackingSystem.Database1DataSet2();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new TrackingSystem.Database1DataSet2TableAdapters.TaskTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Summary";
            this.label13.UseWaitCursor = true;
            // 
            // Donebutton
            // 
            this.Donebutton.Location = new System.Drawing.Point(336, 299);
            this.Donebutton.Name = "Donebutton";
            this.Donebutton.Size = new System.Drawing.Size(75, 23);
            this.Donebutton.TabIndex = 16;
            this.Donebutton.Text = "DONE";
            this.Donebutton.UseVisualStyleBackColor = true;
            this.Donebutton.UseWaitCursor = true;
            this.Donebutton.Click += new System.EventHandler(this.Donebutton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "End Task";
            this.label12.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Start Task";
            this.label11.UseWaitCursor = true;
            // 
            // EndTaskdateTimePicker
            // 
            this.EndTaskdateTimePicker.Location = new System.Drawing.Point(65, 164);
            this.EndTaskdateTimePicker.Name = "EndTaskdateTimePicker";
            this.EndTaskdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.EndTaskdateTimePicker.TabIndex = 13;
            this.EndTaskdateTimePicker.UseWaitCursor = true;
            // 
            // StartTaskdateTimePicker
            // 
            this.StartTaskdateTimePicker.Location = new System.Drawing.Point(65, 114);
            this.StartTaskdateTimePicker.Name = "StartTaskdateTimePicker";
            this.StartTaskdateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.StartTaskdateTimePicker.TabIndex = 12;
            this.StartTaskdateTimePicker.UseWaitCursor = true;
            // 
            // Summary_richTextBox
            // 
            this.Summary_richTextBox.Location = new System.Drawing.Point(400, 137);
            this.Summary_richTextBox.Name = "Summary_richTextBox";
            this.Summary_richTextBox.Size = new System.Drawing.Size(316, 100);
            this.Summary_richTextBox.TabIndex = 11;
            this.Summary_richTextBox.Text = "";
            this.Summary_richTextBox.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Task";
            this.label10.UseWaitCursor = true;
            // 
            // TaskcomboBox
            // 
            this.TaskcomboBox.DataSource = this.taskBindingSource;
            this.TaskcomboBox.DisplayMember = "name";
            this.TaskcomboBox.FormattingEnabled = true;
            this.TaskcomboBox.Location = new System.Drawing.Point(110, 213);
            this.TaskcomboBox.Name = "TaskcomboBox";
            this.TaskcomboBox.Size = new System.Drawing.Size(155, 24);
            this.TaskcomboBox.TabIndex = 9;
            this.TaskcomboBox.UseWaitCursor = true;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.database1DataSet2;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // WorkCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Donebutton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.EndTaskdateTimePicker);
            this.Controls.Add(this.StartTaskdateTimePicker);
            this.Controls.Add(this.Summary_richTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TaskcomboBox);
            this.Name = "WorkCardForm";
            this.Text = "WorkCard";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Donebutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker EndTaskdateTimePicker;
        private System.Windows.Forms.DateTimePicker StartTaskdateTimePicker;
        private System.Windows.Forms.RichTextBox Summary_richTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TaskcomboBox;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Database1DataSet2TableAdapters.TaskTableAdapter taskTableAdapter;
    }
}