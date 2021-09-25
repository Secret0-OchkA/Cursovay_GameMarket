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
    public partial class Form_Library : Form
    {
        public Form_Library(Form form,User user)
        {
            InitializeComponent();
            parent = form;
            userOwner = user;
        }

        private Form parent;
        private User userOwner;



        private void Form_Library_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.placemarks". При необходимости она может быть перемещена или удалена.
            this.placemarksTableAdapter.Fill(this.dataSet.placemarks);
            this.libraryTableAdapter.Fill(this.dataSet.Library, userOwner.login);
            this.shopTableAdapter.Fill(this.dataSet.Shop);
        }

        private void Form_Library_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int placemarkId = (int)(comboBox_PlacemarkShop.SelectedValue ?? 0);
            if (placemarkId == 0)
                this.shopTableAdapter.Fill(this.dataSet.Shop);
            else
                this.shopTableAdapter.Fill_Placemark(this.dataSet.Shop, placemarkId);
        }

        private void comboBox_PlacemarkLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            int placemarkId = (int)(comboBox_PlacemarkLibrary.SelectedValue ?? 0);
            if (placemarkId == 0)
                this.libraryTableAdapter.Fill(this.dataSet.Library, userOwner.login);
            else
                this.libraryTableAdapter.Fill_Placemark(this.dataSet.Library, userOwner.login, placemarkId);
        }

        private void button_Buy_Click(object sender, EventArgs e)
        {
            string gameName = shopDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            int gameId = this.gamesTableAdapter1.GetGameId(gameName).Value;

            if (this.user_gameTableAdapter1.IsGameOwner(userOwner.login, gameId).Value == 0)
            {
                this.user_gameTableAdapter1.User_Game_Insert(userOwner.login, gameId);
                this.Form_Library_Load(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("this game is purchased", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download process", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
