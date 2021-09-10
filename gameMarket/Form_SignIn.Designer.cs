
namespace gameMarket
{
    partial class Form_SignIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_SignIn = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Paswword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_SignIn
            // 
            this.button_SignIn.Location = new System.Drawing.Point(24, 84);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(75, 23);
            this.button_SignIn.TabIndex = 0;
            this.button_SignIn.Text = "Sign in";
            this.button_SignIn.UseVisualStyleBackColor = true;
            // 
            // button_SignUp
            // 
            this.button_SignUp.Location = new System.Drawing.Point(121, 84);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(75, 23);
            this.button_SignUp.TabIndex = 1;
            this.button_SignUp.Text = "Sign up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(121, 24);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(225, 20);
            this.textBox_Login.TabIndex = 2;
            this.textBox_Login.Tag = "";
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(121, 50);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(225, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(21, 27);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(57, 13);
            this.label_Login.TabIndex = 4;
            this.label_Login.Text = "Enter login";
            this.label_Login.Click += new System.EventHandler(this.label_Login_Click);
            // 
            // label_Paswword
            // 
            this.label_Paswword.AutoSize = true;
            this.label_Paswword.Location = new System.Drawing.Point(21, 53);
            this.label_Paswword.Name = "label_Paswword";
            this.label_Paswword.Size = new System.Drawing.Size(80, 13);
            this.label_Paswword.TabIndex = 5;
            this.label_Paswword.Text = "Enter password";
            this.label_Paswword.Click += new System.EventHandler(this.label_Paswword_Click);
            // 
            // Form_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 169);
            this.Controls.Add(this.label_Paswword);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.button_SignIn);
            this.Name = "Form_SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Paswword;
    }
}

