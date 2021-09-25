using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameMarket.Forms
{
    public partial class Form_ChangePlacemark : Form
    {
        public Form_ChangePlacemark(Form form, int gameId)
        {
            InitializeComponent();
            parent = form;
            this.gameId = gameId;
        }

        private Form parent;
        private int gameId;

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_ChangePlacemark_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
        }

        private void Form_ChangePlacemark_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.placemarks". При необходимости она может быть перемещена или удалена.
            this.placemarksTableAdapter.Fill(this.dataSet.placemarks);

            this.placemakrsViewTableAdapter.Fill(this.dataSet.PlacemakrsView, gameId);


        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int placemarkId = (int)dataGridView_Placemarks.SelectedRows[0].Cells[1].Value;

            this.game_placemarkTableAdapter1.Delete_Placemark(gameId,placemarkId);

            this.placemakrsViewTableAdapter.Fill(this.dataSet.PlacemakrsView, gameId);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int placemarkId = (int)comboBox_Placemark.SelectedValue;

            try
            {
                if (this.game_placemarkTableAdapter1.Exist_User_Placemark(gameId,placemarkId) == 1)
                    throw new Exception("this placemark is already there");
                if ((int)comboBox_Placemark.SelectedValue == 0)
                    throw new Exception("");

                this.game_placemarkTableAdapter1.Insert_Placemark(gameId, placemarkId);

                this.placemakrsViewTableAdapter.Fill(this.dataSet.PlacemakrsView, gameId);

            }
            catch(Exception ex)
            {
                label_Errors.Text = ex.Message;
                timer_clearLabelError.Enabled = true;
            }

        }

        private void timer_clearLabelError_Tick(object sender, EventArgs e)
        {
            timer_clearLabelError.Enabled = false;
            label_Errors.Text = string.Empty;
        }
    }
}
