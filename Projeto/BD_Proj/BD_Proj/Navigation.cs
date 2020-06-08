using BD_Proj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Proj
{
    public partial class Navigation : Form
    {
        private SqlConnection cn;
        public Navigation()
        {
            InitializeComponent();
        }

        private void connectToDB()
        {
            cn = new SqlConnection(Helper.CnnVal("p1g3_bd"));

            try
            {
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database" + cn.Database + " on the " + cn.DataSource + " server", "Connection Test");

                }

            }
            catch (Exception execp)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR", "Connection Test");
            }
        }
        private void casasBt_Click(object sender, EventArgs e)
        {
            ShowCasas();
        }

        public void ShowCasas()
        {
            navpanel.Controls.Clear();
            Casas casa = new Casas();
            casa.TopLevel = false;
            navpanel.Controls.Add(casa);
            casa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            casa.Show();
        }

        private void inquilinoBt_Click(object sender, EventArgs e)
        {
            navpanel.Controls.Clear();
            DadosPessoais form1 = new DadosPessoais();
            form1.TopLevel = false;
            navpanel.Controls.Add(form1);
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectToDB();
        }

        private void condominio_bt_Click(object sender, EventArgs e)
        {
            ShowCondominios();
        }

        public void ShowCondominios()
        {
            navpanel.Controls.Clear();
            Condominios cond = new Condominios();
            cond.TopLevel = false;
            navpanel.Controls.Add(cond);
            cond.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cond.Show();
        }

        private void empresa_bt_Click(object sender, EventArgs e)
        {
            ShowEmpresas();
        }

        public void ShowEmpresas()
        {
            navpanel.Controls.Clear();
            Empresas e = new Empresas();
            e.TopLevel = false;
            navpanel.Controls.Add(e);
            e.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            e.Show();
        }

        private void obras_bt_Click(object sender, EventArgs e)
        {
            ShowObras();
        }

        public void ShowObras()
        {
            navpanel.Controls.Clear();
            Obras o = new Obras();
            o.TopLevel = false;
            navpanel.Controls.Add(o);
            o.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            o.Show();
        }

        private void contratos_bt_Click(object sender, EventArgs e)
        {
            ShowContratos();
        }

        public void ShowContratos()
        {
            navpanel.Controls.Clear();
            Contratos c = new Contratos();
            c.TopLevel = false;
            navpanel.Controls.Add(c);
            c.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Owner;
            f.Show();
            this.Close();
        }

        private void Navigation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f = (Form1)Owner;
            f.Show();
            this.Close();
        }
    }
}
