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

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                string userLogin = textBox_Login.Text;
                string userPassword = textBox_Password.Text;

                //проверка на пустые поля
                if (userLogin.Equals(string.Empty) || userPassword.Equals(string.Empty))
                    throw new Exception("No input data");

                DataSet.usersDataTable user = new DataSet.usersDataTable();
                usersTableAdapter1.Fill_GetUser(user, userLogin);

                //проверка на правильно веденный логин
                if (user.Rows.Count == 0)
                    throw new Exception("Invalid login");

                string userBd = user.Rows[0][0].ToString(); //login
                string passwordBd = user.Rows[0][1].ToString(); //password
                User.Role role = (User.Role)Convert.ToInt32(user.Rows[0][2].ToString()); //role

                //проверка на правильно  введенный пароль
                if (!userPassword.Equals(passwordBd))
                    throw new Exception("Incorrect password");

                User userOwner = new User(userBd, passwordBd, role);

                switch (role)
                {
                    case User.Role.ADMIN:
                        Form_Admin form_Admin = new Form_Admin(this, userOwner);
                        form_Admin.Show();
                        break;

                    case User.Role.USER:
                        Form_Library form_Library = new Form_Library(this, userOwner);
                        form_Library.Show();
                        break;

                    default:
                        break;
                }

                Hide();
                textBox_Login.Text = textBox_Password.Text = string.Empty;
            }
            catch(Exception ex)
            {
                label_Error.Text = ex.Message;
                timer_ClearErrors.Enabled = true;
            }
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            Form_SignUp form_SignUp = new Form_SignUp(this);
            Hide();
            textBox_Login.Text = textBox_Password.Text = string.Empty;
            form_SignUp.Show();
        }

        private void timer_ClearErrors_Tick(object sender, EventArgs e)
        {
            timer_ClearErrors.Enabled = false;
            label_Error.Text = string.Empty;
        }
    }
}
