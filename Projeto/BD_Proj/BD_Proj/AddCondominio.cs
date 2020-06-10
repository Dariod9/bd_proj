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
            FillGerenteLisBox();
            adding = true;      // insert
            name_cond_label.Hide();
        }

        public AddCondominio(CondominioModel c)
        {
            InitializeComponent();
            FillGerenteLisBox();
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
            name_cond_label.Text = c.nome;
            add_nome_cond_label.Hide();
            nome_cond_textBox.Hide();
        }

        
        private void addCond_button_Click(object sender, EventArgs e)
        {
            CondominioModel cond = new CondominioModel();
            try
            {
                cond.num_fiscal = Decimal.Parse(num_fical_TextBox.Text.ToString());
                cond.gerente_nif = (gerentes_listBox.SelectedItem as GerenteView).value;
                cond.nome = nome_cond_textBox.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adding)
            {
                SaveCondominio(cond);                
            }
            else
            {
                UpdateCondominio(cond);                
            }
            CondoForm parent = (CondoForm)Owner;
            parent.FillCondominiosLisBox();
            parent.Show();
            this.Close();
        }

        private void SaveCondominio(CondominioModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand("insertCond", data.connection());
            //cmd.CommandText = "INSERT proj_condominio (num_fiscal, gerente_nif, nome) Values(@num_fiscal, @gerente_nif, @nome)";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@num_fiscal", c.num_fiscal);
            cmd.Parameters.AddWithValue("@gerente_nif", c.gerente_nif);
            cmd.Parameters.AddWithValue("@nome", c.nome);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successful!");
            }
            catch (Exception ex)
            {
                //throw new Exception("Failed to insert in database. \n ERROR MESSAGE: \n" + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                data.close();
            }
        }

        private void UpdateCondominio(CondominioModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand("updateCond", data.connection());
            //cmd.CommandText = "UPDATE proj_condominio SET gerente_nif = @gerente_nif WHERE num_fiscal = @num_fiscal";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@num_fiscal", c.num_fiscal);
            cmd.Parameters.AddWithValue("@gerente_nif", c.gerente_nif);
            cmd.Connection = data.connection();

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!");
            }
            catch (Exception ex)
            {
                //throw new Exception("Failed to update in database. \n ERROR MESSAGE: \n" + ex.Message);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                data.close();
            }
        }

        private void FillGerenteLisBox()
        {
            gerentes_listBox.DataSource = GetGerentes();
            gerentes_listBox.DisplayMember = "text";
            gerentes_listBox.ValueMember = "value";
        }

        private List<GerenteView> GetGerentes()
        {
            List<GerenteView> g = new List<GerenteView>();

            data.connectToDB();
            String sql = "SELECT * FROM Show_Gerentes";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                GerenteView gv = new GerenteView();
                gv.value = Decimal.Parse(reader["nif"].ToString());
                gv.text = reader["name"].ToString();

                g.Add(gv);
            }
            data.close();

            return g;
        }
    }
}