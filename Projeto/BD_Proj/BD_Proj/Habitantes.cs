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

        private void GetPessoasByCasa(string morada)
        {
            data.connectToDB();

            List<PessoaModel> pessoas = new List<PessoaModel>();

            String sql = "SELECT * FROM proj_pessoa join proj_casa_inquilino on proj_pessoa.nif=proj_casa_inquilino.nif where morada='"+morada+"'";
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

            //return pessoas;
            fillDataGrid(pessoas);
        }

        private void fillDataGrid<T>(List<T> lista)
        {
            pessoa_dataGrid.DataSource = lista;
          //  pessoa_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            //pessoa_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            AddCasa add = new AddCasa();
            add.ShowDialog();
        }

        private void Pessoa_Load(object sender, EventArgs e)
        {

        }

        private void pessoa_bt_Click(object sender, EventArgs e)
        {
            AddInquilino add = new AddInquilino(moradaGlobal);
            add.ShowDialog();
        }

        private void inquilinos_Click(object sender, EventArgs e)
        {
            printInquilinos();
        }

        private void proprietarios_Click(object sender, EventArgs e)
        {
            printProprietarios();
        }

        private void fiadores_Click(object sender, EventArgs e)
        {
            printFiadores();
        }

        private void DadosPessoais_Load(object sender, EventArgs e)
        {

        }

        public void printFiadores()
        {
            data.connectToDB();

            List<FiadorModel> fiadores = new List<FiadorModel>();

            String sql = "SELECT * FROM (proj_pessoa join proj_fiador on proj_pessoa.nif=proj_fiador.nif)";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                FiadorModel tmp = new FiadorModel();

                tmp.fname = reader.GetString(0);
                tmp.lname = reader.GetString(1);
                tmp.telefone = reader.GetDecimal(2);
                tmp.id = reader.GetDecimal(3);
                tmp.nif = reader.GetDecimal(4);


                fiadores.Add(tmp);
            }
            data.close();

            fillDataGrid(fiadores);
        }



        public void printProprietarios()
        {
            data.connectToDB();

            List<ProprietarioModel> props = new List<ProprietarioModel>();

            String sql = "SELECT * FROM (proj_pessoa join proj_proprietario on proj_pessoa.nif=proj_proprietario.nif)";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ProprietarioModel tmp = new ProprietarioModel();

                tmp.fname = reader.GetString(0);
                tmp.lname = reader.GetString(1);
                tmp.telefone = reader.GetDecimal(2);
                tmp.id = reader.GetDecimal(3);
                tmp.nif = reader.GetDecimal(4);


                props.Add(tmp);
            }
            data.close();

            fillDataGrid(props);
        }

        public void printInquilinos()
        {
            data.connectToDB();

            List<InquilinoModel> inqs = new List<InquilinoModel>();

            String sql = "SELECT * FROM (proj_pessoa join proj_inquilino on proj_pessoa.nif=proj_inquilino.nif)";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                InquilinoModel tmp = new InquilinoModel();

                tmp.fname = reader.GetString(0);
                tmp.lname = reader.GetString(1);
                tmp.telefone = reader.GetDecimal(2);
                tmp.id = reader.GetDecimal(3);
                tmp.nif = reader.GetDecimal(4);
                tmp.certificado = reader.GetString(6);
                tmp.reg_criminal = reader.GetString(7);


                inqs.Add(tmp);
            }
            data.close();

            fillDataGrid(inqs);
        }
    }
}
