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
        public Form_Library()
        {
            InitializeComponent();
        }



        private void Form_Library_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.placemarks". При необходимости она может быть перемещена или удалена.
            this.placemarksTableAdapter.Fill(this.dataSet.placemarks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Library". При необходимости она может быть перемещена или удалена.
            this.libraryTableAdapter.Fill(this.dataSet.Library);

        }

        private void comboBox_placemarker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = libraryTableAdapter.GetData();
            if (comboBox_placemarker.SelectedIndex != 0)
            {
                // если none то все игры
                dt = libraryTableAdapter.GetDataBy_placemarkers("makr1");
            }

            libraryDataGridView.DataSource = dt;
        }
    }
}
