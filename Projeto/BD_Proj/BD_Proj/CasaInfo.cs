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
            String sql = "SELECT * FROM proj_casa where morada='" + casa_selected() + "'";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();

            morada_text.Text = reader.GetString(0);
            quartos_text.Text = ""+reader.GetInt32(1);
            cidade_text.Text = reader.GetString(2);
            habitantes_text.Text = "" +(reader.GetInt32(3));
            descricao_text.Text = reader.GetString(4);
            condo_box.Text = "" + reader.GetDecimal(5);

            data.close();
        }

        private void fillCasaslistbox()
        {
            casas_listBox.DataSource = GetCasas();
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
                CasaView casa = new CasaView();
                casa.morada = reader.GetString(0);

                c.Add(casa.morada);
            }
            data.close();

            return c;
        }

        private string casa_selected()
        {
            return casas_listBox.SelectedItem.ToString();
        }

        private void casas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.connectToDB();
            String sql = "SELECT * FROM proj_casa where morada='" + casa_selected() + "'";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();

            morada_text.Text = reader.GetString(0);
            quartos_text.Text = "" + Int32.Parse(reader.GetString(1));
            cidade_text.Text = reader.GetString(2);
            habitantes_text.Text = "" + Int32.Parse(reader.GetString(3));
            descricao_text.Text = reader.GetString(4);
            condo_box.Text = "" + Decimal.Parse(reader.GetString(5));

            data.close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosPessoais dados = new DadosPessoais(casa_selected());
            dados.ShowDialog();
        }
    }
}
