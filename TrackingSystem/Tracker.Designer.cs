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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TaskTab = new System.Windows.Forms.TabPage();
            this.AddTaskTab = new System.Windows.Forms.TabPage();
            this.WarkCardTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.TaskTab.Location = new System.Drawing.Point(4, 25);
            this.TaskTab.Name = "TaskTab";
            this.TaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.TaskTab.Size = new System.Drawing.Size(792, 375);
            this.TaskTab.TabIndex = 0;
            this.TaskTab.Text = "Tasks";
            this.TaskTab.UseVisualStyleBackColor = true;
            // 
            // AddTaskTab
            // 
            this.AddTaskTab.Location = new System.Drawing.Point(4, 25);
            this.AddTaskTab.Name = "AddTaskTab";
            this.AddTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTaskTab.Size = new System.Drawing.Size(792, 375);
            this.AddTaskTab.TabIndex = 1;
            this.AddTaskTab.Text = "Add Task";
            this.AddTaskTab.UseVisualStyleBackColor = true;
            // 
            // WarkCardTab
            // 
            this.WarkCardTab.Location = new System.Drawing.Point(4, 25);
            this.WarkCardTab.Name = "WarkCardTab";
            this.WarkCardTab.Size = new System.Drawing.Size(792, 375);
            this.WarkCardTab.TabIndex = 2;
            this.WarkCardTab.Text = "WorkCard";
            this.WarkCardTab.UseVisualStyleBackColor = true;
            // 
            // Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tracker";
            this.Text = "Tracker";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TaskTab;
        private System.Windows.Forms.TabPage AddTaskTab;
        private System.Windows.Forms.TabPage WarkCardTab;
    }
}