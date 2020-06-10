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
    public partial class CondoForm : Form
    {
        DataAccess data = new DataAccess();
        public CondoForm()
        {
            InitializeComponent();
            FillCondominiosLisBox();
        }

        private decimal cond_selected()
        {
            return (condominios_listBox.SelectedItem as CondominioView).value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Casas c = new Casas(cond_selected());
            CasaInfo c = new CasaInfo(cond_selected());
            c.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DadosPessoais dadosPessoais = new DadosPessoais((condominios_listBox.SelectedItem as CondominioView).value);
            dadosPessoais.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Obras obras = new Obras((condominios_listBox.SelectedItem as CondominioView).value);
            obras.ShowDialog();
        }

        public void FillCondominiosLisBox()
        {
            condominios_listBox.DataSource = GetCondominios();
            condominios_listBox.DisplayMember = "text";
            condominios_listBox.ValueMember = "value";
        }

        private List<CondominioView> GetCondominios()
        {
            List<CondominioView> c = new List<CondominioView>();

            data.connectToDB();
            String sql = "SELECT * FROM Show_Condominios";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                CondominioView cond = new CondominioView();
                cond.value = Decimal.Parse(reader["num_fiscal"].ToString());
                cond.text = reader["nome"].ToString();

                c.Add(cond);
            }
            data.close();

            return c;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            data.connectToDB();

            CondominioModel cond = new CondominioModel();

            SqlCommand com = new SqlCommand("getCondominio", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@num_fiscal", cond_selected());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                cond.num_fiscal = Decimal.Parse(reader["num_fiscal"].ToString());
                cond.gerente_nif = Decimal.Parse(reader["gerente_nif"].ToString());
                cond.nome = reader["nome"].ToString();
            }
            data.close();

            AddCondominio addCond = new AddCondominio(cond);
            addCond.ShowDialog(this);
        }

        private void CondoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavUtilizador n = (NavUtilizador)Owner;
            n.Show();
            this.Close();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            AddCondominio cond = new AddCondominio();
            this.Hide();
            cond.ShowDialog(this);
        }
    }
}
