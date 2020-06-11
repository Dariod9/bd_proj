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
    public partial class Habitantes : Form
    {
        DataAccess data = new DataAccess();
        string moradaGlobal;
        public Habitantes()
        {
            InitializeComponent();
            GetPessoas();
        }

        public Habitantes(string morada)
        {
            InitializeComponent();
            GetPessoasByCasa(morada);
            moradaGlobal = morada;
        }

        public void GetPessoasByCasa(string morada)
        {
            data.connectToDB();

            List<PessoaModel> pessoas = new List<PessoaModel>();

            //String sql = "SELECT * FROM proj_pessoa join proj_casa_inquilino on proj_pessoa.nif=proj_casa_inquilino.nif where morada='"+morada+"'";
            SqlCommand com = new SqlCommand("getPessoasByCasa", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@morada", morada);
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

        public void GetPessoas()
        {
            data.connectToDB();

            List<PessoaModel> pessoas = new List<PessoaModel>();

            String sql = "SELECT * FROM proj_pessoa";
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

        public void fillDataGrid<T>(List<T> lista)
        {
            pessoa_dataGrid.DataSource = lista;
        }

        private void pessoa_bt_Click(object sender, EventArgs e)
        {
            AddInquilino add = new AddInquilino(moradaGlobal);
            add.ShowDialog(this);
        }
    }
}
