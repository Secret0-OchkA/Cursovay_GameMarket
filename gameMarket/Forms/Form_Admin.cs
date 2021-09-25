using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gameMarket.Forms;


namespace gameMarket
{
    public partial class Form_Admin : Form
    {
        public Form_Admin(Form form, User user)
        {
            InitializeComponent();
            parent = form;
            userOwner = user;
            openFileDialog1.Filter = "Изображения|*.png;*.jpg";
        }

        private User userOwner;
        private Form parent;

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.servers". При необходимости она может быть перемещена или удалена.
            this.serversTableAdapter.Fill(this.dataSet.servers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.gameStudios". При необходимости она может быть перемещена или удалена.
            this.gameStudiosTableAdapter.Fill(this.dataSet.gameStudios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.GamesView". При необходимости она может быть перемещена или удалена.
            this.gamesViewTableAdapter.Fill(this.dataSet.GamesView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.GamesView". При необходимости она может быть перемещена или удалена.
            this.gamesViewTableAdapter.Fill(this.dataSet.GamesView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.dataSet.roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.UserView". При необходимости она может быть перемещена или удалена.
            this.userViewTableAdapter.Fill(this.dataSet.UserView);

        }

        private string imagePath;
        private string imageName;

        private void button_SelectImage_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageName = openFileDialog1.SafeFileName;
                    imagePath = openFileDialog1.FileName.Replace("\\" + imageName, string.Empty);

                    pictureDataPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("couldn't open the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int maxLengthPassword = 16;
        private int minLengthPassword = 8;

        private void button_UsUp_Password_Click(object sender, EventArgs e)
        {
            try
            {
                if (usersDataGridView.SelectedRows.Count == 0)
                    throw new Exception("no selected user");

                string login = loginTextBox_Update.Text;
                string password = passwordTextBox_Update.Text;

                if (password.Length > maxLengthPassword || password.Length < minLengthPassword)
                    throw new Exception("password must be from 8 to 16 characters");

                int role = (int)comboBox_RoleUpdate.SelectedValue;

                this.usersTableAdapter1.User_Update(password, role, login);

                this.userViewTableAdapter.Fill(this.dataSet.UserView);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button__Click(object sender, EventArgs e)
        {
            try
            {
                if (usersDataGridView.SelectedRows.Count == 0)
                    throw new Exception("no selected user");

                string login = textBox_Delete.Text;

                this.usersTableAdapter1.User_Delete(login);

                this.userViewTableAdapter.Fill(this.dataSet.UserView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_GaUp_Studio_Click(object sender, EventArgs e)
        {
            try
            {
                if (gamesDataGridView.SelectedRows.Count == 0)
                    throw new Exception("no selected game");

                int gameStudio = (int)comboBox_GameStudio.SelectedValue;
                string gameNameOld = gamesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string gameNameNew = nameTextBox.Text;

                if (this.gamesTableAdapter1.GetGameId(gameNameNew).HasValue)
                    throw new Exception("this name is busy");

                double price = (double)numericUpDown_Price.Value;
                int serverId = (int)comboBox_Server.SelectedValue;
                int? gameId = gamesTableAdapter1.GetGameId(gameNameOld);

                gamesTableAdapter1.Game_Update(gameStudio, gameNameNew, serverId, price, gameNameOld);
                picturesTableAdapter1.DeletePicture(gameNameNew);
                picturesTableAdapter1.usp_ImportImage(gameId, "name", imagePath, imageName);
                

                this.gamesViewTableAdapter.Fill(this.dataSet.GamesView);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        

        private void button_Ga_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gamesDataGridView.SelectedRows.Count == 0)
                    throw new Exception("no selected game");

                string deleteGame = textBox_DeleteGame.Text;
                gamesTableAdapter1.Game_Delete(deleteGame);
                this.gamesViewTableAdapter.Fill(this.dataSet.GamesView);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void button_ChangePlacemark_Click(object sender, EventArgs e)
        {
            try
            {
                if (gamesDataGridView.SelectedRows.Count == 0)
                    throw new Exception("no selected game");

                string gameName = gamesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                int gameId = gamesTableAdapter1.GetGameId(gameName).Value;
                Form_ChangePlacemark form_ChangePlacemark = new Form_ChangePlacemark(this, gameId);
                form_ChangePlacemark.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Library_Click(object sender, EventArgs e)
        {
            Form_Library form_Library = new Form_Library(this, userOwner);
            form_Library.Show();
            Hide();
        }

        private void Form_Admin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
