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
    public partial class Form_Admin : Form
    {
        public Form_Admin(Form form)
        {
            InitializeComponent();
            parent = form;
        }

        private Form parent;

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.gameStudios". При необходимости она может быть перемещена или удалена.
            this.gameStudiosTableAdapter.Fill(this.dataSet.gameStudios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.servers". При необходимости она может быть перемещена или удалена.
            this.serversTableAdapter.Fill(this.dataSet.servers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.dataSet.roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.games". При необходимости она может быть перемещена или удалена.
            this.gamesTableAdapter.Fill(this.dataSet.games);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.dataSet.users);

        }

        private void button_UsUp_Password_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            int role = (int)comboBox_Role.SelectedValue;

            usersTableAdapter.User_Update(password, role, login);

            this.usersTableAdapter.Fill(this.dataSet.users);
        }

        private void button__Click(object sender, EventArgs e)
        {
            string login = loginTextBox_Delete.Text;

            usersTableAdapter.User_Delete(login);

            this.usersTableAdapter.Fill(this.dataSet.users);
        }

        private void button_GaUp_Studio_Click(object sender, EventArgs e)
        {
            int gameStudio = (int)comboBox_Studio.SelectedValue;
            string name = nameTextBox.Text;
            int id = Convert.ToInt32(idTextBox.Text);
            if (comboBox_Server.SelectedValue == null)
            {
                gamesTableAdapter.Game_Update(gameStudio, name, null, id);
            }
            else
            {
                int server = (int)comboBox_Server.SelectedValue;
                gamesTableAdapter.Game_Update(gameStudio, name, server, id);
            }
            

            this.gamesTableAdapter.Fill(this.dataSet.games);
        }

        private void button_Ga_Delete_Click(object sender, EventArgs e)
        {
            gamesTableAdapter.Game_Delete(nameTextBox1_Delete.Text);

            this.gamesTableAdapter.Fill(this.dataSet.games);
        }

        private void button_AddGame_Click(object sender, EventArgs e)
        {
            Form_AddGame addGame = new Form_AddGame(this);
            this.Enabled = false;
            addGame.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
