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
            this.Hide();
            condoForm.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CasaInfo casas = new CasaInfo();
            this.Hide();
            casas.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contratos contratos = new Contratos();
            contratos.ShowDialog();
        }

        private void NavUtilizador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = (Form1)Owner;
            f.Show();
            this.Close();
        }
    }
}
