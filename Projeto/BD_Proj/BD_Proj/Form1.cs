using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == textBox2.Text.ToString())
            {
                NavUtilizador navU = new NavUtilizador();
                this.Hide();
                navU.ShowDialog();
            }
            else
            {
                Navigation nav = new Navigation();
                this.Hide();
                nav.ShowDialog(this);
            }
        }
    }
}
