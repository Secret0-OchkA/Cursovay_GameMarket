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

        private enum Role
        {
            ADMIN,
            USER
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

            bool exist = Convert.ToBoolean(usersTableAdapter1.ExistUser(userLogin));

            if(exist)
            {
                DataSet.usersDataTable user = new DataSet.usersDataTable();
                usersTableAdapter1.Fill_GetUser(user, userLogin);

                string userBd = user.Rows[0][0].ToString(); //login
                string passwordBd = user.Rows[0][1].ToString(); //password
                Role role = (Role)Convert.ToInt32(user.Rows[0][2].ToString()); //role

                if (userLogin.Equals(userBd) && userPassword.Equals(passwordBd))
                {
                    switch (role)
                    {
                        case Role.ADMIN:
                            Form_Admin form_Admin = new Form_Admin(this);
                            form_Admin.Show();

                            break;
                        case Role.USER:
                            Form_User form_User = new Form_User(this);
                            form_User.Show();
                            break;
                        default:
                            break;
                    }

                    Hide();
                    textBox_Login.Text = textBox_Password.Text = string.Empty;
                }
                   
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp form_SignUp = new Form_SignUp(this);
            Hide();
        }
    }
}
