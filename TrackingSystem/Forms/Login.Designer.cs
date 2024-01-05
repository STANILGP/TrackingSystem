namespace TrackingSystem
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameTextBoxLogin = new System.Windows.Forms.TextBox();
            this.PasswordTextBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // UserNameTextBoxLogin
            // 
            this.UserNameTextBoxLogin.Location = new System.Drawing.Point(330, 151);
            this.UserNameTextBoxLogin.Name = "UserNameTextBoxLogin";
            this.UserNameTextBoxLogin.Size = new System.Drawing.Size(175, 22);
            this.UserNameTextBoxLogin.TabIndex = 1;
            this.UserNameTextBoxLogin.Validating += new System.ComponentModel.CancelEventHandler(this.UserNameTextBoxLogin_Validating);
            // 
            // PasswordTextBoxLogin
            // 
            this.PasswordTextBoxLogin.Location = new System.Drawing.Point(330, 207);
            this.PasswordTextBoxLogin.Name = "PasswordTextBoxLogin";
            this.PasswordTextBoxLogin.Size = new System.Drawing.Size(175, 22);
            this.PasswordTextBoxLogin.TabIndex = 2;
            this.PasswordTextBoxLogin.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextBoxLogin_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(211, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(384, 280);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "LogIn";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTextBoxLogin);
            this.Controls.Add(this.UserNameTextBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameTextBoxLogin;
        private System.Windows.Forms.TextBox PasswordTextBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}