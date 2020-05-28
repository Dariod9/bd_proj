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
            fillDataGrid();
        }

        private List<CondominioModel> GetCondominios()
        {
            data.connectToDB();

            List<CondominioModel> cond = new List<CondominioModel>();

            String sql = "SELECT * FROM proj_condominio";
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

        private void fillDataGrid()
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
    }
}
