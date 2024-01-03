namespace TrackingSystem
{
    partial class SINGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.GO_TO_REGISTRATION_FORM_BUTTON = new System.Windows.Forms.Button();
            this.GO_TO_LOGIN_FORM_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(193, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRACKING SYSTEM";
            // 
            // GO_TO_REGISTRATION_FORM_BUTTON
            // 
            this.GO_TO_REGISTRATION_FORM_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GO_TO_REGISTRATION_FORM_BUTTON.Location = new System.Drawing.Point(240, 142);
            this.GO_TO_REGISTRATION_FORM_BUTTON.Name = "GO_TO_REGISTRATION_FORM_BUTTON";
            this.GO_TO_REGISTRATION_FORM_BUTTON.Size = new System.Drawing.Size(290, 40);
            this.GO_TO_REGISTRATION_FORM_BUTTON.TabIndex = 1;
            this.GO_TO_REGISTRATION_FORM_BUTTON.Text = "Create New Profile";
            this.GO_TO_REGISTRATION_FORM_BUTTON.UseVisualStyleBackColor = true;
            this.GO_TO_REGISTRATION_FORM_BUTTON.Click += new System.EventHandler(this.GO_TO_REGISTRATION_FORM_BUTTON_Click);
            // 
            // GO_TO_LOGIN_FORM_BUTTON
            // 
            this.GO_TO_LOGIN_FORM_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GO_TO_LOGIN_FORM_BUTTON.Location = new System.Drawing.Point(240, 209);
            this.GO_TO_LOGIN_FORM_BUTTON.Name = "GO_TO_LOGIN_FORM_BUTTON";
            this.GO_TO_LOGIN_FORM_BUTTON.Size = new System.Drawing.Size(290, 40);
            this.GO_TO_LOGIN_FORM_BUTTON.TabIndex = 2;
            this.GO_TO_LOGIN_FORM_BUTTON.Text = "LOGIN";
            this.GO_TO_LOGIN_FORM_BUTTON.UseVisualStyleBackColor = true;
            this.GO_TO_LOGIN_FORM_BUTTON.Click += new System.EventHandler(this.GO_TO_LOGIN_FORM_BUTTON_Click);
            // 
            // SINGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GO_TO_LOGIN_FORM_BUTTON);
            this.Controls.Add(this.GO_TO_REGISTRATION_FORM_BUTTON);
            this.Controls.Add(this.label1);
            this.Name = "SINGIN";
            this.Text = "SINGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GO_TO_REGISTRATION_FORM_BUTTON;
        private System.Windows.Forms.Button GO_TO_LOGIN_FORM_BUTTON;
    }
}