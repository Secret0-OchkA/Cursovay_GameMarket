using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameMarket
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp(Form form)
        {
            InitializeComponent();
            parent = form;
        }

        private Form parent;

        private readonly string errorCharsStr = "@#%^?|\\-+/\'\"&`~(){}[]*.,<>:; ";

        private readonly int maxLengthLogin = 16;
        private readonly int minLengthLogin = 8;

        private readonly int maxLengthPassword = 16;
        private readonly int minLengthPassword = 8;

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = !((CheckBox)sender).Checked;
            textBox_PasswordRepeat.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;
            string password = textBox_Password.Text;
            string passwordRepeat = textBox_PasswordRepeat.Text;

            try
            {
                if (login.Equals(string.Empty) || password.Equals(string.Empty) || passwordRepeat.Equals(string.Empty))
                    throw new Exception("No input data");

                if (login.Length > maxLengthLogin || login.Length < minLengthLogin)
                    throw new Exception("login must be from 8 to 16 characters");

                if (password.Length > maxLengthPassword || password.Length < minLengthPassword)
                    throw new Exception("password must be from 8 to 16 characters");

                if (login.IndexOfAny(errorCharsStr.ToCharArray()) != -1)
                    throw new Exception("login must not contain: " + errorCharsStr);

                if ((int)this.usersTableAdapter1.ExistUser(login) != 0)
                    throw new Exception("This login is busy");

                if (password.IndexOfAny(errorCharsStr.ToCharArray()) != -1)
                    throw new Exception("password must not contain: " + errorCharsStr);

                if (!password.Equals(passwordRepeat))
                    throw new Exception("passwords don't match");



                usersTableAdapter1.User_Insert(login, password, 1);
                Close();
            }
            catch(Exception ex)
            {
                label_Error.Text = ex.Message;
                timer_ClearError.Enabled = true;
            }



        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void timer_ClearError_Tick(object sender, EventArgs e)
        {
            timer_ClearError.Enabled = false;
            label_Error.Text = string.Empty;
        }
    }
}
