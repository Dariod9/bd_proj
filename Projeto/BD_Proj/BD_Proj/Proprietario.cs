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
    public partial class Proprietario : Form
    {
        DataAccess data = new DataAccess();
        string moradaGlobal;
        public Proprietario()
        {
            InitializeComponent();
            GetPessoas();
        }

        public Proprietario(string morada)
        {
            InitializeComponent();
            GetPessoasByCasa(morada);
            moradaGlobal = morada;
        }

        public void GetPessoasByCasa(string morada)
        {
            data.connectToDB();

            List<ProprietarioModel> pessoas = new List<ProprietarioModel>();

            //String sql = "SELECT * FROM (proj_pessoa join proj_tem_casa on proj_tem_casa.nif=proj_pessoa.nif) where morada='" + morada+"'";
            SqlCommand com = new SqlCommand("getPropsByCasa", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@morada", morada);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ProprietarioModel tmp = new ProprietarioModel();

                tmp.fname = reader["fname"].ToString();
                tmp.lname = reader["lname"].ToString();
                tmp.telefone = Decimal.Parse(reader["telefone"].ToString());
                tmp.id = Decimal.Parse(reader["id"].ToString());
                tmp.nif = Decimal.Parse(reader["nif"].ToString());
                tmp.morada = morada;
                tmp.ini = DateTime.Parse(reader["data_ini"].ToString());
                tmp.fim = DateTime.Parse(reader["data_fim"].ToString());

                pessoas.Add(tmp);
            }
            data.close();

            //return pessoas;
            fillDataGrid(pessoas);
        }

        //private void Fill_listbox()
        //{
        //    data.connectToDB();
        //    String sql = "SELECT morada FROM proj_pessoa";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        pessoas_listBox.Items.Add(reader.GetValue(0));
        //    }
        //    data.close();
        //}

        private void GetPessoas()
        {
            data.connectToDB();

            List<PessoaModel> pessoas = new List<PessoaModel>();

            String sql = "SELECT * FROM proj_proprietario";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                PessoaModel tmp = new PessoaModel();

                tmp.fname = reader.GetString(0);
                tmp.lname = reader.GetString(1);
                tmp.telefone = reader.GetDecimal(2);
                tmp.id = reader.GetDecimal(3);
                tmp.nif = reader.GetDecimal(4);

                pessoas.Add(tmp);
            }
            data.close();

            fillDataGrid(pessoas);
        }

        private void fillDataGrid<T>(List<T> lista)
        {
            pessoa_dataGrid.DataSource = lista;
        }

        private void pessoa_bt_Click(object sender, EventArgs e)
        {
            AddProprietario add = new AddProprietario(moradaGlobal);
            add.ShowDialog(this);
        }
    }
}
