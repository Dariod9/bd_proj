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
    public partial class addContratoRenda : Form
    {
        DataAccess data = new DataAccess();
        public addContratoRenda()
        {
            InitializeComponent();
            FillInquilinoBox();
            FillFiadorBox();
            FillEmpresaBox();
            FillPropBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContratoRendaModel inq = new ContratoRendaModel();
            try
            {
                inq.codigo = Decimal.Parse(codigoBox.Text);
                inq.data_ini = DateTime.Parse(data1.Text.ToString());
                inq.data_fim = DateTime.Parse(data2.Text.ToString());
                inq.dia_pagamento = Int32.Parse(diaBox.Text.ToString());
                inq.proprietario = getNifProp(proprietarioBox.Text.ToString());
                inq.renda = Int32.Parse(rendaBox.Text.ToString());
                inq.caucao = Int32.Parse(caucaoBox.Text.ToString());
                inq.taxa = Int32.Parse(taxaBox.Text.ToString());
                inq.fiador =getNifProp(fiadorBox.Text.ToString());
                inq.inquilino =getNifProp(inquilinoBox1.Text.ToString());
                inq.empresa = getNifEmpresa(empresaBox2.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            save(inq);
            MessageBox.Show("Entry Successful!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save(ContratoRendaModel inq)
        {
            data.connectToDB();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec inserirContratoRenda @cod, @data1, @data2, @dia, @prop, @renda, @caucao, @taxa, @fiador, @inquilino, @empresa"; //"INSERT proj_contrato (codigo, data_ini, data_fim, dia_pagamento, proprietario) values(@cod, @data1, @data2, @dia, @prop)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cod", inq.codigo);
            cmd.Parameters.AddWithValue("@data1", inq.data_ini);
            cmd.Parameters.AddWithValue("@data2", inq.data_fim);
            cmd.Parameters.AddWithValue("@dia", inq.dia_pagamento);
            cmd.Parameters.AddWithValue("@prop", inq.proprietario);
            //cmd.Connection = data.connection();



            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.CommandText = "INSERT proj_contrato_renda (codigo, renda, caucao, taxa, fiador, inquilino, empresa) values(@cod, @renda, @caucao, @taxa, @fiador, @inquilino, @empresa)";
            //cmd2.Parameters.Clear();
            //cmd2.Parameters.AddWithValue("@cod", inq.codigo);
            cmd.Parameters.AddWithValue("@renda", inq.renda);
            cmd.Parameters.AddWithValue("@caucao", inq.caucao);
            cmd.Parameters.AddWithValue("@taxa", inq.taxa);
            cmd.Parameters.AddWithValue("@fiador", inq.fiador);
            cmd.Parameters.AddWithValue("@inquilino", inq.inquilino);
            cmd.Parameters.AddWithValue("@empresa", inq.empresa);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
                //cmd2.ExecuteNonQuery();
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

        private void FillFiadorBox()
        {
            List<Decimal> fiad = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT nif FROM proj_fiador";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                fiadorBox.Items.Add(getNomeProp(reader.GetDecimal(0)));
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
                proprietarioBox.Items.Add(getNomeProp(reader.GetDecimal(0)));
            }
            data.close();
        }

        private void FillInquilinoBox()
        {
            List<Decimal> fiad = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT nif FROM proj_inquilino";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                inquilinoBox1.Items.Add(getNomeProp(reader.GetDecimal(0)));
            }
            data.close();
        }

        private void FillEmpresaBox()
        {
            List<Decimal> fiad = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT nif FROM proj_empresa";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                empresaBox2.Items.Add(getNomeEmpresa(reader.GetDecimal(0)));
            }
            data.close();
        }
        private string getNomeEmpresa(decimal nif)
        {
            data.connectToDB();
            String sql = "SELECT nome FROM proj_empresa where nif=" + nif + "";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetString(0);
            reader.Close();
            data.close();
            return a;
        }

        private string getNomeProp(decimal nif)
        {
            data.connectToDB();
            String sql = "SELECT fname, lname FROM proj_pessoa where nif=" + nif + "";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetString(0) + " " + reader.GetString(1);
            reader.Close();
            data.close();
            return a;
        }

        private decimal getNifProp(string nome)
        {
            data.connectToDB();
            String[] tmp = nome.Split(' ');
            String sql = "SELECT nif FROM proj_pessoa where lname='" + tmp[1] + "' and fname='" + tmp[0] + "'";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetDecimal(0);
            reader.Close();
            data.close();
            return a;
        }

        private decimal getNifEmpresa(string nome)
        {
            data.connectToDB();
            String[] tmp = nome.Split(' ');
            String sql = "SELECT nif FROM proj_empresa where nome='" + nome + "'";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetDecimal(0);
            reader.Close();
            data.close();
            return a;
        }

    }
}
