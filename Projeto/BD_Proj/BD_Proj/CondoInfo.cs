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
    public partial class CondoForm : Form
    {
        public CondoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Casas c = new Casas();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DadosPessoais dadosPessoais = new DadosPessoais();
            dadosPessoais.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Obras obras = new Obras();
            obras.ShowDialog();
        }
    }
}
