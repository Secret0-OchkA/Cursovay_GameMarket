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
        public Form_SignUp()
        {
            InitializeComponent();
        }
        private readonly string errorCharsStr = "@#%^?|\\-+/\'\"&`~(){}[]*.,<>: ";
        private readonly int maxLengthNickname = 16;
        private readonly int maxLengthPassword = 16;

//=========================================function - start=============================================

        private delegate bool Condition<T,U>(T arg1, U arg2);

        //print msg in label_Error
        private bool printErrorMsg<T,U>(Condition<T,U> func, T str1, U str2, string errorMsg)
        {
            if (func(str1, str2))
            {
                if (!label_Error.Text.Contains(errorMsg))
                {
                    label_Error.Text += errorMsg + "\n";
                }
                return false;
            }
            else
            {
                label_Error.Text = label_Error.Text.Replace(errorMsg + "\n", string.Empty);
                return true;
            }
        }

        //=========================================function - end===============================================
        private void textBox_Nickname_TextChanged(object sender, EventArgs e)
        {
            string nickname = textBox_Nickname.Text;

            string errorSpecCharMsg = "ник не должен содеражть: " + errorCharsStr;
            Condition<string,string> CheakSpecChar = (string checkedStr, string specCharsStr) => checkedStr.IndexOfAny(specCharsStr.ToCharArray()) != -1;
            printErrorMsg(CheakSpecChar, nickname, errorCharsStr, errorSpecCharMsg);

            string errorLengthMsg = $"ник должен состоять из {maxLengthNickname} или менее символов";
            Condition<string, int> CheakLenght = (string checkedStr, int length) => !(checkedStr.Length <= length);
            printErrorMsg(CheakLenght, nickname, maxLengthNickname, errorLengthMsg);
        }

        private void textBox_PasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            string passwordRepeat = textBox_PasswordRepeat.Text;

            string errorEqualsPassMsg = "пароли не совподают\n";
            Condition<string, string> CheakEqualsPassword = (string chekedPassword, string Password) => !passwordRepeat.Equals(textBox_Password.Text);
            printErrorMsg(CheakEqualsPassword, passwordRepeat, textBox_Password.Text, errorEqualsPassMsg);
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            string password = textBox_Password.Text;

            string errorMsg = "парль не должен содеражть: " + errorCharsStr;
            Condition<string, string> CheakSpecChar = (string checkedStr, string specCharsStr) => checkedStr.IndexOfAny(specCharsStr.ToCharArray()) != -1;
            printErrorMsg(CheakSpecChar, password, errorCharsStr, errorMsg);

            string errorLengthMsg = $"пароль должен состоять из {maxLengthPassword} или менее символов";
            Condition<string, int> CheakLenght = (string checkedStr, int length) => !(checkedStr.Length <= length);
            printErrorMsg(CheakLenght, password, maxLengthPassword, errorLengthMsg);

            textBox_PasswordRepeat_TextChanged(this, new EventArgs());
        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = !((CheckBox)sender).Checked;
            textBox_PasswordRepeat.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }
    }
}
