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
    public partial class NavUtilizador : Form
    {
        public NavUtilizador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CondoForm condoForm = new CondoForm();
            condoForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Casas casas = new Casas();
            casas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contratos contratos = new Contratos();
            contratos.ShowDialog();
        }
    }
}
