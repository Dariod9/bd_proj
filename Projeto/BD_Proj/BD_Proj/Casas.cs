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
            Fill_listbox();
            fillDataGrid();
        }

        private void Fill_listbox()
        {
            data.connectToDB();
            String sql = "SELECT morada FROM proj_casa";
            SqlCommand com = new SqlCommand(sql, DataAccess.cn);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                casas_listBox.Items.Add(reader.GetValue(0));
            }
            data.close();
        }

        private List<Casa> GetCasas2()
        {
            data.connectToDB();

            List<Casa> casas = new List<Casa>();

            String sql = "SELECT * FROM proj_casa";
            SqlCommand com = new SqlCommand(sql, DataAccess.cn);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                Casa tmp = new Casa();

                tmp.morada = reader.GetString(0);
                tmp.n_quartos = reader.GetInt32(1);
                tmp.cidade = reader.GetString(2);
                tmp.max_hab = reader.GetInt32(3);
                tmp.descricao = reader.GetString(4);
                //tmp.condominio = reader.GetInt32(5);

                casas.Add(tmp);
            }
            data.close();

            return casas;
        }

        private void fillDataGrid()
        {
            casas_dataGrid.DataSource = GetCasas2();
        }
    }
}
