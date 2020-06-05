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
    public partial class addContratoCondo : Form
    {
        DataAccess data = new DataAccess();
        public addContratoCondo()
        {
            InitializeComponent();
            FillCondoBox();
            FillPropBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContratoCondominioModel inq = new ContratoCondominioModel();
            try
            {
                inq.codigo = Decimal.Parse(codigoBox.Text);
                inq.data_ini = DateTime.Parse(data1.Text.ToString());
                inq.data_fim = DateTime.Parse(data2.Text.ToString());
                inq.dia_pagamento = Int32.Parse(diaBox.Text.ToString());
                inq.proprietario = Decimal.Parse(proprietarioBox.Text.ToString());
                inq.condominio = Decimal.Parse(condoBox.Text.ToString());
                inq.despesas = Int32.Parse(despesaBox.Text.ToString());
                inq.area = Int32.Parse(areaBox.Text.ToString());
                inq.seguro = seguroBox.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            save(inq);
            MessageBox.Show("Entry Successful!");
            this.Close();
        }

        private void save(ContratoCondominioModel inq)
        {
            data.connectToDB();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT proj_contrato (codigo, data_ini, data_fim, dia_pagamento, proprietario) values(@cod, @data1, @data2, @dia, @prop)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cod", inq.codigo);
            cmd.Parameters.AddWithValue("@data1", inq.data_ini);
            cmd.Parameters.AddWithValue("@data2", inq.data_fim);
            cmd.Parameters.AddWithValue("@dia", inq.dia_pagamento);
            cmd.Parameters.AddWithValue("@prop", inq.proprietario);
            cmd.Connection = data.connection();



            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "INSERT proj_contrato_condominio (codigo, despesas, seguro, area, condominio) values(@cod, @despesa, @seguro, @area, @condo)";
            cmd2.Parameters.Clear();
            cmd2.Parameters.AddWithValue("@cod", inq.codigo);
            cmd2.Parameters.AddWithValue("@despesa", inq.despesas);
            cmd2.Parameters.AddWithValue("@seguro", inq.seguro);
            cmd2.Parameters.AddWithValue("@area", inq.area);
            cmd2.Parameters.AddWithValue("@condo", inq.condominio);
            cmd2.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to insert in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                data.close();
                // DadosPessoais.printInquilinos();

            }
        }

        private void FillCondoBox()
        {
            List<Decimal> conds = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT num_fiscal FROM proj_condominio";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                condoBox.Items.Add(reader.GetDecimal(0));
            }
            data.close();
        }

        private void FillPropBox()
        {

            List<Decimal> props = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT nif FROM proj_proprietario";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                proprietarioBox.Items.Add(reader.GetDecimal(0));
            }
            data.close();
        }
    }
}
