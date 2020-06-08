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
    public partial class Casas : Form
    {
        DataAccess data = new DataAccess();
        public Casas()
        {
            InitializeComponent();
            fillDataGrid();
        }

        public Casas(decimal condominio)
        {
            InitializeComponent();
            GetCasasByCondominio(condominio);            
        }

        private List<CasaModel> GetCasas2()
        {
            data.connectToDB();

            List<CasaModel> casas = new List<CasaModel>();

            String sql = "SELECT * FROM proj_casa";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                CasaModel tmp = new CasaModel();

                tmp.morada = reader.GetString(0);
                tmp.n_quartos = reader.GetInt32(1);
                tmp.cidade = reader.GetString(2);
                tmp.max_hab = reader.GetInt32(3);
                tmp.descricao = reader.GetString(4);
                tmp.condominio = reader.GetDecimal(5);

                casas.Add(tmp);
            }
            data.close();

            return casas;
        }

        private void GetCasasByCondominio(decimal condominio)
        {
            data.connectToDB();

            SqlCommand com = new SqlCommand("getCasasByCondominio", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@condominio", condominio);
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(com);
            DataTable objDataTable = new DataTable();
            objSqlDataAdapter.Fill(objDataTable);
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = objDataTable;
            casas_dataGrid.DataSource = objBindingSource;
            objSqlDataAdapter.Update(objDataTable);

            casas_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            casas_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";

            data.close();
        }

        private void fillDataGrid()
        {
            casas_dataGrid.DataSource = GetCasas2();           
            casas_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            casas_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            AddCasa add = new AddCasa();
            add.ShowDialog(this);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            string morada = casas_dataGrid.CurrentRow.Cells[0].Value.ToString();
            CasaModel tmp = new CasaModel();

            data.connectToDB();
            //String sql = String.Format("SELECT * FROM proj_casa WHERE morada = '" + morada + "'");
            //MessageBox.Show(sql);
            SqlCommand com = new SqlCommand("getCasaByMorada", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@morada", morada);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                tmp.morada = reader.GetString(0);
                tmp.n_quartos = reader.GetInt32(1);
                tmp.cidade = reader.GetString(2);
                tmp.max_hab = reader.GetInt32(3);
                tmp.descricao = reader.GetString(4);
                tmp.condominio = reader.GetDecimal(5);
            }
            data.close();

            AddCasa addCasa = new AddCasa(tmp);
            addCasa.ShowDialog(this);
        }

        private string getNome(string nif)
        {
            data.connectToDB();
            String sql = "SELECT nome FROM proj_condominio where num_fiscal=" + nif + "";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetString(0);
            reader.Close();
            data.close();
            return a;
        }


    }
}
