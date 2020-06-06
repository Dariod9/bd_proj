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
            FillCondominioComboBox();
        }

        public AddObra(ObraModel o)
        {
            InitializeComponent();
            adding = false;
            FillCondominioComboBox();
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
                obra.condominio = getNifCond(condominio_comboBox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adding)
            {
                SaveObra(obra);
                MessageBox.Show("Entry Successful!");
            }
            else
            {
                UpdateObra(obra);
                MessageBox.Show("Update Successful!");
            }

            Navigation parent = (Navigation) Owner;
            parent.ShowObras();
            this.Close();
        }

        private void SaveObra(ObraModel o)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "INSERT proj_obras (obra_id, data_ini, data_fim, orcamento, condominio) Values(@obra_id, @data_ini, @data_fim, @orcamento, @condominio)";
            cmd.CommandText = "EXEC insertObra @obra_id, @data_ini, @data_fim, @orcamento, @condominio";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@obra_id", o.obra_id);
            cmd.Parameters.AddWithValue("@data_ini", o.data_ini);
            cmd.Parameters.AddWithValue("@data_fim", o.data_fim);
            cmd.Parameters.AddWithValue("@orcamento", o.orcamento);
            cmd.Parameters.AddWithValue("@condominio", o.condominio);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to insert in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                data.close();
            }
        }

        private void UpdateObra(ObraModel o)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "UPDATE proj_obras SET data_ini = @data_ini, "
            //                + "data_fim = @data_fim, orcamento = @orcamento, "
            //                + "condominio = @condominio WHERE obra_id = @obra_id";
            cmd.CommandText = "EXEC updateObra @obra_id, @data_ini, @data_fim, @orcamento, @condominio";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@obra_id", o.obra_id);
            cmd.Parameters.AddWithValue("@data_ini", o.data_ini);
            cmd.Parameters.AddWithValue("@data_fim", o.data_fim);
            cmd.Parameters.AddWithValue("@orcamento", o.orcamento);
            cmd.Parameters.AddWithValue("@condominio", o.condominio);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                data.close();
            }
        }

        private void FillCondominioComboBox()
        {
            List<Decimal> conds = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT num_fiscal FROM proj_condominio";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                condominio_comboBox.Items.Add(getNomeCond(reader.GetDecimal(0)));
            }
            data.close();
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

        private decimal getNifCond(string nome)
        {
            data.connectToDB();
            String[] tmp = nome.Split(' ');
            //String sql = "SELECT num_fiscal FROM proj_condominio where nome='" + nome + "'";
            SqlCommand com = new SqlCommand("getNumFiscalCond", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nome", nome);
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
