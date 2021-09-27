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
    public partial class Form_AddGame : Form
    {
        public Form_AddGame(Form_Admin form)
        {
            InitializeComponent();
            parent = form;
            openFileDialog1.Filter = "Изображения|*.png;*.jpg";
        }

        private Form_Admin parent;

        private string imageName;
        private string imagePath;


        private void Form_AddGame_Load(object sender, EventArgs e)
        {
            this.serversTableAdapter.Fill(this.dataSet.servers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.gameStudios". При необходимости она может быть перемещена или удалена.
            this.gameStudiosTableAdapter.Fill(this.dataSet.gameStudios);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.games". При необходимости она может быть перемещена или удалена.
            //this.gamesTableAdapter.Fill(this.dataSet.games);

        }

        private void button_SelectImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageName = openFileDialog1.SafeFileName;
                    imagePath = openFileDialog1.FileName.Replace("\\" + imageName, string.Empty);

                    pictureBox_Logo.Image = new Bitmap(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            
        }

        private void Form_AddGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
            parent.Form_Admin_Load(this, new EventArgs());
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            int gameStudio = (int)comboBox_Studio.SelectedValue;
            string nameGame = nameTextBox.Text;
            int serverId = (int)comboBox_Server.SelectedValue;
            double price = (double)numericUpDown_Price.Value;


            try
            {
                if (nameGame.Equals(string.Empty))
                    throw new Exception("no game name");

                if (imageName == null)
                    throw new Exception("no logo");

                if (gamesTableAdapter.GetGameId(nameGame).HasValue)
                    throw new Exception("this name is busy");

                gamesTableAdapter.Game_Insert(gameStudio, nameGame, serverId, price);
                
                int addedGameId = (int)gamesTableAdapter.GetGameId(nameGame);

                if ((int)picturesTableAdapter1.ExistPicture(imageName) == 1)
                    throw new Exception("this image is busy");

                picturesTableAdapter1.usp_ImportImage(addedGameId, "name", imagePath, imageName);

                parent.Refresh();

                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gamesTableAdapter.Game_Delete(nameGame);
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
