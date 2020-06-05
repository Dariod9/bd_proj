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
    public partial class Condominios : Form
    {
        DataAccess data = new DataAccess();
        public Condominios()
        {
            InitializeComponent();
            //FillDataGrid();
            FillDataGrid2();            
        }

        private List<CondominioModel> GetCondominios()
        {
            data.connectToDB();

            List<CondominioModel> cond = new List<CondominioModel>();

            String sql = "SELECT * FROM proj_condominio;";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                CondominioModel tmp = new CondominioModel();

                tmp.num_fiscal = reader.GetDecimal(0);
                tmp.gerente_nif = reader.GetDecimal(1);

                cond.Add(tmp);
            }
            data.close();

            return cond;
        }

        private void FillDataGrid2()
        {
            data.connectToDB();

            String sql = "SELECT num_fiscal, nome, gerente_nif, sg.name FROM proj_condominio AS cond JOIN Show_Gerentes AS sg ON cond.gerente_nif = sg.nif";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataAdapter objSqlDataAdapter = new SqlDataAdapter(com);
            DataTable objDataTable = new DataTable();
            objSqlDataAdapter.Fill(objDataTable);
            BindingSource objBindingSource = new BindingSource();
            objBindingSource.DataSource = objDataTable;
            cond_dataGridView.DataSource = objBindingSource;
            objSqlDataAdapter.Update(objDataTable);

            cond_dataGridView.Columns["num_fiscal"].HeaderText = "Número de Condomínio";
            cond_dataGridView.Columns["gerente_nif"].HeaderText = "Gerente de Condomínio";
            cond_dataGridView.Columns["nome"].HeaderText = "Nome do Condomínio";
            cond_dataGridView.Columns["name"].HeaderText = "Nome do Gerente";

            data.close();
        }

        public void FillDataGrid()
        {
            cond_dataGridView.DataSource = GetCondominios();
            cond_dataGridView.Columns["num_fiscal"].HeaderText = "Número de Condomínio";
            cond_dataGridView.Columns["gerente_nif"].HeaderText = "Gerente de Condomínio";
        }

        private void add_cond_bt_Click(object sender, EventArgs e)
        {
            AddCondominio add = new AddCondominio();
            add.ShowDialog();
        }

        private void mudar_gerente_bt_Click(object sender, EventArgs e)
        {
            string num_fiscal = cond_dataGridView.CurrentRow.Cells[0].Value.ToString();

            data.connectToDB();

            CondominioModel cond = new CondominioModel();

            String sql = String.Format("SELECT * FROM proj_condominio WHERE num_fiscal = '" + num_fiscal + "'");
            //MessageBox.Show(sql);

            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                cond.num_fiscal = reader.GetDecimal(0);
                cond.gerente_nif = reader.GetDecimal(1);
            }
            data.close();

            AddCondominio addCond = new AddCondominio(cond);
            addCond.ShowDialog(this);
        }
    }
}
