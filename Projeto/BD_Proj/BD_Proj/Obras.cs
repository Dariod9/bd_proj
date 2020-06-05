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
            //FillObrasDataGrid();
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
                //tmp.data_ini = reader["data_ini"].ToString();
                //tmp.data_fim =                num sei ler as datas xD
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
        }
    }
}
