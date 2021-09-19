﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameMarket;

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

        private readonly string errorCharsStr = "@#%^?|\\-+/\'\"&`~(){}[]*.,<>: ";
        private readonly int maxLengthNickname = 16;
        private readonly int maxLengthPassword = 16;

        private string nickname;
        private string password;

        private void textBox_Nickname_TextChanged(object sender, EventArgs e)
        {
            nickname = textBox_Nickname.Text;

            string errorSpecCharMsg = "ник не должен содеражть: " + errorCharsStr;
            PrintLableMsg.Condition<string,string> CheakSpecChar = (string checkedStr, string specCharsStr) 
                => checkedStr.IndexOfAny(specCharsStr.ToCharArray()) != -1;

            PrintLableMsg.printErrorMsg(CheakSpecChar, nickname, errorCharsStr, errorSpecCharMsg,label_Error);

            string errorLengthMsg = $"ник должен состоять из {maxLengthNickname} или менее символов";
            PrintLableMsg.Condition<string, int> CheakLenght = (string checkedStr, int length) 
                => !(checkedStr.Length <= length);

            PrintLableMsg.printErrorMsg(CheakLenght, nickname, maxLengthNickname, errorLengthMsg,label_Error);
        }

        private void textBox_PasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            string passwordRepeat = textBox_PasswordRepeat.Text;

            string errorEqualsPassMsg = "пароли не совподают\n";
            PrintLableMsg.Condition<string, string> CheakEqualsPassword = (string chekedPassword, string Password) 
                => !passwordRepeat.Equals(textBox_Password.Text);

            PrintLableMsg.printErrorMsg(CheakEqualsPassword, passwordRepeat, textBox_Password.Text, errorEqualsPassMsg,label_Error);
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            password = textBox_Password.Text;

            string errorMsg = "парль не должен содеражть: " + errorCharsStr;
            PrintLableMsg.Condition<string, string> CheakSpecChar = (string checkedStr, string specCharsStr) 
                => checkedStr.IndexOfAny(specCharsStr.ToCharArray()) != -1;

            PrintLableMsg.printErrorMsg(CheakSpecChar, password, errorCharsStr, errorMsg,label_Error);

            string errorLengthMsg = $"пароль должен состоять из {maxLengthPassword} или менее символов";
            PrintLableMsg.Condition<string,int> CheakLenght = (string checkedStr, int length) 
                => !(checkedStr.Length <= length);

            PrintLableMsg.printErrorMsg(CheakLenght, password, maxLengthPassword, errorLengthMsg,label_Error);

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

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            int existUser = (int)(usersTableAdapter1.ExistUser(nickname));

            string errorMsg = $"пользователь с таким ником уже существует";
            if (existUser == 1)
            {
                if (!label_Error.Text.Contains(errorMsg))
                {
                    label_Error.Text += errorMsg + "\n";
                }
            }
            else
            {
                label_Error.Text = label_Error.Text.Replace(errorMsg + "\n", string.Empty);
            }

            string error = label_Error.Text;
            
            if (error.Equals(string.Empty))
            {
                usersTableAdapter1.User_Insert(nickname, password, 1);
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
    }
}
