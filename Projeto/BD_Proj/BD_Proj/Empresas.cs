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
    public partial class Empresas : Form
    {
        DataAccess data = new DataAccess();
        public Empresas()
        {
            InitializeComponent();
            FillEmpresasDataGrid();
        }

        private List<EmpresaModel> GetEmpresas()
        {
            data.connectToDB();

            List<EmpresaModel> empresas = new List<EmpresaModel>();

            String sql = "SELECT * FROM proj_empresa";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                EmpresaModel tmp = new EmpresaModel();

                tmp.nome = reader["nome"].ToString();
                tmp.nif = Decimal.Parse(reader["nif"].ToString());
                tmp.email = reader["email"].ToString();
                tmp.contacto = Decimal.Parse(reader["contacto"].ToString());

                empresas.Add(tmp);
            }
            data.close();

            return empresas;
        }

        private void FillEmpresasDataGrid()
        {
            empresas_dataGridView1.DataSource = GetEmpresas();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            AddEmpresa em = new AddEmpresa();
            em.ShowDialog();
        }

        private void edit_bt_Click(object sender, EventArgs e)
        {
            string nif = empresas_dataGridView1.CurrentRow.Cells["nif"].Value.ToString();

            // ir buscar à bd a empresa com o nif selecionado
            data.connectToDB();
            EmpresaModel tmp = new EmpresaModel();

            //String sql = String.Format("SELECT * FROM proj_empresa WHERE nif = '" + nif + "'");
            //MessageBox.Show(sql);
            SqlCommand com = new SqlCommand("getEmpresaByNif", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nif", nif);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                tmp.nome = reader["nome"].ToString();
                tmp.nif = Decimal.Parse(reader["nif"].ToString());
                tmp.email = reader["email"].ToString();
                tmp.contacto = Decimal.Parse(reader["contacto"].ToString());
            }
            data.close();

            AddEmpresa emp = new AddEmpresa(tmp);
            emp.ShowDialog(this);
        }
    }
}
