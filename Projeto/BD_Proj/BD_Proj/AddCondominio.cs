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
    public partial class AddCondominio : Form
    {
        DataAccess data = new DataAccess();
        private bool adding;
        public AddCondominio()
        {
            InitializeComponent();
            FillGerenteComboBox();
            adding = true;      // insert
        }

        public AddCondominio(CondominioModel c)
        {
            InitializeComponent();
            FillGerenteComboBox();
            FillCondInfo(c);
            adding = false;     // update
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillCondInfo(CondominioModel c)
        {
            num_fical_TextBox.Text = c.num_fiscal.ToString();
            num_fical_TextBox.ReadOnly = true;
            gerente_comboBox.Text = c.gerente_nif.ToString();
        }

        private void FillGerenteComboBox()
        {
            List<Decimal> pessoas = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT nif FROM proj_pessoa";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                gerente_comboBox.Items.Add(reader.GetDecimal(0));
            }
            data.close();
        }

        private void addCond_button_Click(object sender, EventArgs e)
        {
            CondominioModel cond = new CondominioModel();
            try
            {
                cond.num_fiscal = Decimal.Parse(num_fical_TextBox.Text.ToString());
                cond.gerente_nif = Decimal.Parse(gerente_comboBox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adding)
            {
                SaveCondominio(cond);
                MessageBox.Show("Entry Successful!");
            }
            else
            {
                UpdateCondominio(cond);
                MessageBox.Show("Update Successful!");
            }
            Navigation parent = (Navigation) Owner;
            parent.ShowCondominios();
            this.Close();
        }

        private void SaveCondominio(CondominioModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT proj_condominio (num_fiscal, gerente_nif) Values(@num_fiscal, @gerente_nif)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@num_fiscal", c.num_fiscal);
            cmd.Parameters.AddWithValue("@gerente_nif", c.gerente_nif);
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

        private void UpdateCondominio(CondominioModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE proj_condominio SET gerente_nif = @gerente_nif WHERE num_fiscal = @num_fiscal";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@num_fiscal", c.num_fiscal);
            cmd.Parameters.AddWithValue("@gerente_nif", c.gerente_nif);
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
    }
}
