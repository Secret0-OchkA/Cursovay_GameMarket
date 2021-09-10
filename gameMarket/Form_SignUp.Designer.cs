
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
            this.label_Login = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_PasswordRepeat = new System.Windows.Forms.TextBox();
            this.label_PasswordRepeat = new System.Windows.Forms.Label();
            this.textBox_Nickname = new System.Windows.Forms.TextBox();
            this.label_Nickname = new System.Windows.Forms.Label();
            this.label_Error = new System.Windows.Forms.Label();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(12, 54);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(80, 13);
            this.label_Login.TabIndex = 0;
            this.label_Login.Text = "Enter your login";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(135, 51);
            this.textBox_Login.MaxLength = 100;
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(141, 20);
            this.textBox_Login.TabIndex = 1;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(135, 77);
            this.textBox_Password.MaxLength = 100;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(141, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 80);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 13);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Create password";
            // 
            // textBox_PasswordRepeat
            // 
            this.textBox_PasswordRepeat.Location = new System.Drawing.Point(135, 103);
            this.textBox_PasswordRepeat.MaxLength = 100;
            this.textBox_PasswordRepeat.Name = "textBox_PasswordRepeat";
            this.textBox_PasswordRepeat.Size = new System.Drawing.Size(141, 20);
            this.textBox_PasswordRepeat.TabIndex = 5;
            this.textBox_PasswordRepeat.UseSystemPasswordChar = true;
            this.textBox_PasswordRepeat.TextChanged += new System.EventHandler(this.textBox_PasswordRepeat_TextChanged);
            // 
            // label_PasswordRepeat
            // 
            this.label_PasswordRepeat.AutoSize = true;
            this.label_PasswordRepeat.Location = new System.Drawing.Point(12, 106);
            this.label_PasswordRepeat.Name = "label_PasswordRepeat";
            this.label_PasswordRepeat.Size = new System.Drawing.Size(113, 13);
            this.label_PasswordRepeat.TabIndex = 4;
            this.label_PasswordRepeat.Text = "Repeat your password";
            // 
            // textBox_Nickname
            // 
            this.textBox_Nickname.Location = new System.Drawing.Point(135, 25);
            this.textBox_Nickname.MaxLength = 100;
            this.textBox_Nickname.Name = "textBox_Nickname";
            this.textBox_Nickname.Size = new System.Drawing.Size(141, 20);
            this.textBox_Nickname.TabIndex = 7;
            this.textBox_Nickname.TextChanged += new System.EventHandler(this.textBox_Nickname_TextChanged);
            // 
            // label_Nickname
            // 
            this.label_Nickname.AutoSize = true;
            this.label_Nickname.Location = new System.Drawing.Point(12, 28);
            this.label_Nickname.Name = "label_Nickname";
            this.label_Nickname.Size = new System.Drawing.Size(67, 13);
            this.label_Nickname.TabIndex = 6;
            this.label_Nickname.Text = "Create name";
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(12, 134);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(34, 13);
            this.label_Error.TabIndex = 8;
            this.label_Error.Text = "Errors";
            // 
            // button_SignUp
            // 
            this.button_SignUp.Location = new System.Drawing.Point(12, 281);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(75, 23);
            this.button_SignUp.TabIndex = 11;
            this.button_SignUp.Text = "Sign up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(305, 281);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(282, 79);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(101, 17);
            this.checkBox_ShowPassword.TabIndex = 13;
            this.checkBox_ShowPassword.Text = "Show password";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassword_CheckedChanged);
            // 
            // Form_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 313);
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.textBox_Nickname);
            this.Controls.Add(this.label_Nickname);
            this.Controls.Add(this.textBox_PasswordRepeat);
            this.Controls.Add(this.label_PasswordRepeat);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_Login);
            this.Name = "Form_SignUp";
            this.Text = "Form_signUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_PasswordRepeat;
        private System.Windows.Forms.Label label_PasswordRepeat;
        private System.Windows.Forms.TextBox textBox_Nickname;
        private System.Windows.Forms.Label label_Nickname;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBox_ShowPassword;
    }
}