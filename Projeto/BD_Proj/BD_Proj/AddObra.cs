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
    public partial class AddObra : Form
    {
        DataAccess data = new DataAccess();
        private bool adding;
        public AddObra()
        {
            InitializeComponent();
            adding = true;
            FillCondominioBox();
            FillEmpresaLisBox();
        }

        public AddObra(ObraModel o)
        {
            InitializeComponent();
            adding = false;
            FillCondominioBox();
            FillEmpresaLisBox();
            FillObraInfo(o);
        }

        private void FillObraInfo(ObraModel o)
        {
            id_textBox.Text = o.obra_id.ToString();
            id_textBox.ReadOnly = true;
            ini_dateTimePicker.Text = o.data_ini.ToString();
            fim_dateTimePicker.Text = o.data_fim.ToString();
            orcamento_textBox.Text = o.orcamento.ToString();
            condominio_comboBox.Text = getNomeCond(o.condominio);
            empresa_comboBox.Text = getNomeEmpresa(o.empresa);
            empresa_comboBox.Enabled = false;
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_bt_Click(object sender, EventArgs e)
        {
            ObraModel obra = new ObraModel();
            try
            {
                obra.obra_id = Int32.Parse(id_textBox.Text);
                obra.data_ini = DateTime.Parse(ini_dateTimePicker.Text.ToString());
                obra.data_fim = DateTime.Parse(fim_dateTimePicker.Text.ToString());
                obra.orcamento = Int32.Parse(orcamento_textBox.Text.ToString());
                obra.condominio = (condominio_comboBox.SelectedItem as CondominioView).value;
                obra.empresa = (empresa_comboBox.SelectedItem as EmpresaView).value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adding)
            {
                SaveObra(obra);
            }
            else
            {
                UpdateObra(obra);
            }

            Obras parent = (Obras) Owner;
            parent.GetObrasByCondominio(obra.condominio);
            this.Close();
        }

        private void SaveObra(ObraModel o)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand("insertObra", data.connection());
            //cmd.CommandText = "INSERT proj_obras (obra_id, data_ini, data_fim, orcamento, condominio) Values(@obra_id, @data_ini, @data_fim, @orcamento, @condominio)";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@obra_id", o.obra_id);
            cmd.Parameters.AddWithValue("@data_ini", o.data_ini);
            cmd.Parameters.AddWithValue("@data_fim", o.data_fim);
            cmd.Parameters.AddWithValue("@orcamento", o.orcamento);
            cmd.Parameters.AddWithValue("@condominio", o.condominio);
            cmd.Parameters.AddWithValue("@empresa", o.empresa);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successful!");
            }
            catch (Exception ex)
            {
                //throw new Exception("Failed to insert in database. \n ERROR MESSAGE: \n" + ex.Message);
                MessageBox.Show("Não foi possível guardar os dados! Verifique os campos inseridos!");
            }
            finally
            {
                data.close();
            }
        }

        private void UpdateObra(ObraModel o)
        {
            data.connectToDB();

            //cmd.CommandText = "UPDATE proj_obras SET data_ini = @data_ini, "
            //                + "data_fim = @data_fim, orcamento = @orcamento, "
            //                + "condominio = @condominio WHERE obra_id = @obra_id";
            SqlCommand cmd = new SqlCommand("updateObra", data.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@obra_id", o.obra_id);
            cmd.Parameters.AddWithValue("@data_ini", o.data_ini);
            cmd.Parameters.AddWithValue("@data_fim", o.data_fim);
            cmd.Parameters.AddWithValue("@orcamento", o.orcamento);
            cmd.Parameters.AddWithValue("@condominio", o.condominio);
            cmd.Parameters.AddWithValue("empresa", o.empresa);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!");
            }
            catch (Exception ex)
            {
                //throw new Exception("Failed to update in database. \n ERROR MESSAGE: \n" + ex.Message);
                MessageBox.Show("Não foi possível atualizar os dados! Verifique os campos inseridos!");
            }
            finally
            {
                data.close();
            }
        }

        //private void FillCondominioComboBox()
        //{
        //    List<Decimal> conds = new List<Decimal>();

        //    data.connectToDB();
        //    String sql = "SELECT DISTINCT num_fiscal FROM proj_condominio";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        condominio_comboBox.Items.Add(getNomeCond(reader.GetDecimal(0)));
        //    }
        //    data.close();
        //}

        private void FillCondominioBox()
        {
            condominio_comboBox.DataSource = GetConds();
            condominio_comboBox.DisplayMember = "text";
            condominio_comboBox.ValueMember = "value";
        }

        private List<CondominioView> GetConds()
        {
            List<CondominioView> e = new List<CondominioView>();

            data.connectToDB();
            String sql = "SELECT * FROM Show_Condominios";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                CondominioView ee = new CondominioView();
                ee.value = Decimal.Parse(reader["num_fiscal"].ToString());
                ee.text = reader["nome"].ToString();

                e.Add(ee);
            }
            data.close();

            return e;
        }

        private string getNomeCond(decimal nif)
        {
            data.connectToDB();
            //String sql = "SELECT nome FROM proj_condominio where num_fiscal=" + nif + "";
            SqlCommand com = new SqlCommand("getNomeCond", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@num_fiscal", nif);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetString(0);
            reader.Close();
            data.close();
            return a;
        }

        //private decimal getNifCond(string nome)
        //{
        //    data.connectToDB();
        //    String[] tmp = nome.Split(' ');
        //    //String sql = "SELECT num_fiscal FROM proj_condominio where nome='" + nome + "'";
        //    SqlCommand com = new SqlCommand("getNumFiscalCond", data.connection());
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.Parameters.AddWithValue("@nome", nome);
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    reader.Read();
        //    var a = reader.GetDecimal(0);
        //    reader.Close();
        //    data.close();
        //    return a;
        //}

        private void FillEmpresaLisBox()
        {
            empresa_comboBox.DataSource = GetEmpresas();
            empresa_comboBox.DisplayMember = "text";
            empresa_comboBox.ValueMember = "value";
        }

        private List<EmpresaView> GetEmpresas()
        {
            List<EmpresaView> e = new List<EmpresaView>();

            data.connectToDB();
            String sql = "SELECT * FROM Show_Empresas";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                EmpresaView ee = new EmpresaView();
                ee.value = Decimal.Parse(reader["nif"].ToString());
                ee.text = reader["nome"].ToString();

                e.Add(ee);
            }
            data.close();

            return e;
        }

        private string getNomeEmpresa(decimal empresa)
        {
            data.connectToDB();
            SqlCommand com = new SqlCommand("getNomeEmpresaByNif", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nif", empresa);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            string nome = reader.GetString(0);
            reader.Close();
            data.close();
            
            return nome;
        }
    }
}
