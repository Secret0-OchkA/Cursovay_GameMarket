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
    public partial class Form_User : Form
    {
        public Form_User(Form form)
        {
            InitializeComponent();
            parent = form;
        }

        private Form parent;

        private void Form_User_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
