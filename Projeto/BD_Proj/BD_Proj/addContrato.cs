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
    public partial class addContrato : Form
    {
        public addContrato()
        {
            InitializeComponent();
        }

        private void button_addRenda_Click(object sender, EventArgs e)
        {
            addContratoRenda add = new addContratoRenda();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addContratoCondo add = new addContratoCondo();
            add.ShowDialog();
        }
    }
}
