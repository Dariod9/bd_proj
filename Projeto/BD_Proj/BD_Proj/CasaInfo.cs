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
    public partial class CasaInfo : Form
    {
        DataAccess data = new DataAccess();
        public CasaInfo()
        {
            InitializeComponent();
            fillCasaslistbox();
            casas_listBox.SelectedValueChanged += new EventHandler(Casas_listBox_SelectedValueChanged);
        }

        private void Casas_listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            data.connectToDB();
            //String sql = "SELECT * FROM proj_casa where morada='" + casa_selected() + "'";
            SqlCommand com = new SqlCommand("getCasaByMorada", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@morada", casa_selected());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();

            morada_text.Text = reader.GetString(0);
            quartos_text.Text = ""+reader.GetInt32(1);
            cidade_text.Text = reader.GetString(2);
            habitantes_text.Text = "" +(reader.GetInt32(3));
            descricao_text.Text = reader.GetString(4);
            condo_box.Text = getNomeCond(reader.GetDecimal(5));

            data.close();
        }

        public void fillCasaslistbox()
        {
            casas_listBox.DataSource = GetCasas();
            //casas_listBox.DisplayMember = "morada";
            //casas_listBox.ValueMember = "morada";
        }

        public void fillCasaslistbox(List<String> search)
        {
            casas_listBox.DataSource = search;
            //casas_listBox.DisplayMember = "morada";
            //casas_listBox.ValueMember = "morada";
        }

        private List<String> GetCasas()
        {
            List<String> c = new List<String>();

            data.connectToDB();
            String sql = "SELECT * FROM Moradas";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                c.Add(reader.GetString(0));
            }
            data.close();

            return c;
        }

        private string casa_selected()
        {
            return casas_listBox.SelectedItem.ToString();
        }

        //private void casas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    data.connectToDB();
        //    String sql = "SELECT * FROM proj_casa where morada='" + casa_selected() + "'";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();

        //    morada_text.Text = reader.GetString(0);
        //    quartos_text.Text = "" + Int32.Parse(reader.GetString(1));
        //    cidade_text.Text = reader.GetString(2);
        //    habitantes_text.Text = "" + Int32.Parse(reader.GetString(3));
        //    descricao_text.Text = reader.GetString(4);
        //    condo_box.Text = getNomeCond(reader.GetDecimal(5));

        //    data.close();


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Habitantes dados = new Habitantes(casa_selected());
            dados.ShowDialog();
        }

        private void CasaInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            NavUtilizador n = (NavUtilizador)Owner;
            n.Show();
            this.Close();
        }

        private string getNomeCond(decimal nif)
        {
            data.connectToDB();
            //String sql = "SELECT nome FROM proj_condominio where num_fiscal=" + nif + "";
            SqlCommand com = new SqlCommand("getNomeCond", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@num_fiscal", nif);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetString(0);
            reader.Close();
            data.close();
            return a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCasa add = new AddCasa();
            add.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            AddCasa add = new AddCasa(getCasa(casa_selected()));
            add.ShowDialog(this);
        }

        private CasaModel getCasa(string morada)
        {
            data.connectToDB();
            //String sql = "SELECT n_quartos, cidade, max_hab, descricao, condominio FROM proj_casa where morada='" + morada + "'";
            SqlCommand com = new SqlCommand("getCasaByMorada2", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@morada", morada);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            CasaModel c = new CasaModel();
            c.morada = morada;
            c.n_quartos = reader.GetInt32(0);
            c.cidade = reader.GetString(1);
            c.max_hab = reader.GetInt32(2);
            c.descricao = reader.GetString(3);
            c.condominio = reader.GetDecimal(4);
            reader.Close();
            data.close();
            return c;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                fillCasaslistbox();
            }
            else
            {
                var a = GetCasas();

                fillCasaslistbox(a.Where(x => x.ToLower().Contains(textBox1.Text.ToLower())).ToList());
            }
        }
    }
}
