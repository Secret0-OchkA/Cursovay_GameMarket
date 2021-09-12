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
    public partial class Form_SignIn : Form
    {
        public Form_SignIn()
        {
            InitializeComponent();
        }

        private readonly int maxLengthPassword = 16;

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            string password = textBox_Password.Text;

            string errorLengthMsg = $"пароль должен состоять из {maxLengthPassword} или менее символов";
            PrintLableMsg.Condition<string, int> CheakLenght = (string checkedStr, int length)
                 => !(checkedStr.Length <= length);

            PrintLableMsg.printErrorMsg(CheakLenght, password, maxLengthPassword, errorLengthMsg, label_Error);
        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            string userLogin = textBox_Login.Text;
            string userPassword = textBox_Password.Text;
            bool exist = (bool)usersTableAdapter1.ExistUser(userLogin, userPassword);
            if(exist)
            {

            }
        }
    }
}
