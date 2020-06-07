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
    public partial class Obras : Form
    {
        DataAccess data = new DataAccess();
        public Obras()
        {
            InitializeComponent();
            FillObrasDataGrid();
        }

        public Obras(decimal condominio)
        {
            InitializeComponent();
            GetObrassByCondominio(condominio);
        }

        private List<ObraModel> GetObras()
        {
            data.connectToDB();

            List<ObraModel> obras = new List<ObraModel>();

            String sql = "SELECT * FROM proj_obras";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ObraModel tmp = new ObraModel();

                tmp.obra_id = Int32.Parse(reader["obra_id"].ToString());
                tmp.data_ini = DateTime.Parse(reader["data_ini"].ToString());
                tmp.data_fim = DateTime.Parse(reader["data_fim"].ToString());
                tmp.orcamento = Int32.Parse(reader["orcamento"].ToString());
                tmp.condominio = Decimal.Parse(reader["condominio"].ToString());

                obras.Add(tmp);
            }
            data.close();

            return obras;
        }

        private void FillObrasDataGrid()
        {
            obras_dataGridView1.DataSource = GetObras();
            setHeaders();
        }

        private void GetObrassByCondominio(decimal condominio)
        {
            data.connectToDB();

            SqlCommand com = new SqlCommand("getObrassByCondominio", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@condominio", condominio);
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(com);
            DataTable objDataTable = new DataTable();
            objSqlDataAdapter.Fill(objDataTable);
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = objDataTable;
            obras_dataGridView1.DataSource = objBindingSource;
            objSqlDataAdapter.Update(objDataTable);

            setHeaders();

            data.close();
        }

        private void setHeaders()
        {
            obras_dataGridView1.Columns["data_ini"].HeaderText = "Data Início";
            obras_dataGridView1.Columns["data_fim"].HeaderText = "Data Fim";
            obras_dataGridView1.Columns["orcamento"].HeaderText = "Orçamento (€)";
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            string obra_id = obras_dataGridView1.CurrentRow.Cells[0].Value.ToString();

            // ir buscar à bd a casa com a morada
            data.connectToDB();
            ObraModel tmp = new ObraModel();

            String sql = String.Format("SELECT * FROM proj_obras WHERE obra_id = '" + obra_id + "'");
            //MessageBox.Show(sql);
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                tmp.obra_id = Int32.Parse(reader["obra_id"].ToString());
                tmp.data_ini = DateTime.Parse(reader["data_ini"].ToString());
                tmp.data_fim = DateTime.Parse(reader["data_fim"].ToString());
                tmp.orcamento = Int32.Parse(reader["orcamento"].ToString());
                tmp.condominio = Decimal.Parse(reader["condominio"].ToString());
            }
            data.close();

            AddObra o = new AddObra(tmp);
            o.ShowDialog(this);
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            AddObra obra = new AddObra();
            obra.ShowDialog(this);
        }
    }
}
