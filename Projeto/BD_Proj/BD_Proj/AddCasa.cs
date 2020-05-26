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
    public partial class AddCasa : Form
    {
        DataAccess data = new DataAccess();

        public AddCasa()
        {
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_bt_Click(object sender, EventArgs e)
        {
            CasaModel casa = new CasaModel();
            try
            {
                casa.morada = morada_textbox.Text;
                casa.cidade = cidade_textbox.Text;
                casa.descricao = descricao_textbox.Text;
                casa.n_quartos = (int) n_quartos_comboBox.SelectedItem;
                casa.max_hab = (int) max_hab_comboBox.SelectedItem;
                casa.condominio = (decimal) n_quartos_comboBox.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            saveCasa(casa);
        }

        private void saveCasa(CasaModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT proj_casa (morada, n_quartos, cidade, max_hab, descricao, condominio) Values(@morada, @n_quartos, @cidade, @max_hab, @descricao, @condominio)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@morada", c.morada);
            cmd.Parameters.AddWithValue("@n_quartos", c.n_quartos);
            cmd.Parameters.AddWithValue("@cidade", c.cidade);
            cmd.Parameters.AddWithValue("@max_hab", c.max_hab);
            cmd.Parameters.AddWithValue("@descricao", c.descricao);
            cmd.Parameters.AddWithValue("@condominio", c.condominio);
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
    }
}
