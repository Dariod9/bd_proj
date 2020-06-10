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
    public partial class addPessoa : Form
    {
        public addPessoa()
        {
            InitializeComponent();
        }

        private void addInq_Click(object sender, EventArgs e)
        {
            AddInquilino add = new AddInquilino();
            add.ShowDialog();
        }

        private void addProp_Click(object sender, EventArgs e)
        {
            AddProprietario add = new AddProprietario();
            add.ShowDialog();
        }

        private void addFiador_Click(object sender, EventArgs e)
        {
            AddFiador add = new AddFiador();
            add.ShowDialog();
        }
    }
}
