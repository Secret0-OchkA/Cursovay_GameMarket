
namespace gameMarket
{
    partial class Form_SignUp
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_PasswordRepeat = new System.Windows.Forms.TextBox();
            this.label_PasswordRepeat = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.usersTableAdapter1 = new gameMarket.DataSetTableAdapters.usersTableAdapter();
            this.timer_ClearError = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(135, 50);
            this.textBox_Password.MaxLength = 100;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(141, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 53);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 13);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Create password";
            // 
            // textBox_PasswordRepeat
            // 
            this.textBox_PasswordRepeat.Location = new System.Drawing.Point(135, 76);
            this.textBox_PasswordRepeat.MaxLength = 100;
            this.textBox_PasswordRepeat.Name = "textBox_PasswordRepeat";
            this.textBox_PasswordRepeat.Size = new System.Drawing.Size(141, 20);
            this.textBox_PasswordRepeat.TabIndex = 5;
            this.textBox_PasswordRepeat.UseSystemPasswordChar = true;
            // 
            // label_PasswordRepeat
            // 
            this.label_PasswordRepeat.AutoSize = true;
            this.label_PasswordRepeat.Location = new System.Drawing.Point(12, 79);
            this.label_PasswordRepeat.Name = "label_PasswordRepeat";
            this.label_PasswordRepeat.Size = new System.Drawing.Size(113, 13);
            this.label_PasswordRepeat.TabIndex = 4;
            this.label_PasswordRepeat.Text = "Repeat your password";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(135, 25);
            this.textBox_Login.MaxLength = 100;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(141, 20);
            this.textBox_Login.TabIndex = 7;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(12, 28);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(63, 13);
            this.label_Login.TabIndex = 6;
            this.label_Login.Text = "Create login";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(12, 106);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 13);
            this.label_Error.TabIndex = 8;
            // 
            // button_SignUp
            // 
            this.button_SignUp.Location = new System.Drawing.Point(15, 136);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(75, 23);
            this.button_SignUp.TabIndex = 11;
            this.button_SignUp.Text = "Sign up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            this.button_SignUp.Click += new System.EventHandler(this.button_SignUp_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(308, 136);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(282, 53);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(101, 17);
            this.checkBox_ShowPassword.TabIndex = 13;
            this.checkBox_ShowPassword.Text = "Show password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // timer_ClearError
            // 
            this.timer_ClearError.Interval = 2000;
            this.timer_ClearError.Tick += new System.EventHandler(this.timer_ClearError_Tick);
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 171);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_PasswordRepeat);
            this.Controls.Add(this.label_PasswordRepeat);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_SignUp";
            this.Text = "Form_signUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SignUp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_PasswordRepeat;
        private System.Windows.Forms.Label label_PasswordRepeat;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
        private DataSetTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.Timer timer_ClearError;
    }
}