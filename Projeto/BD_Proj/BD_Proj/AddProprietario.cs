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
    public partial class AddProprietario : Form
    {
        DataAccess data = new DataAccess();

        public AddProprietario()
        {
            InitializeComponent();
            morada_text.ReadOnly = false;
        }

        public AddProprietario(String morada)
        {
            InitializeComponent();
            morada_text.Text = morada;
            morada_text.ReadOnly = true;
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_bt_Click(object sender, EventArgs e)
        {
            ProprietarioModel inq = new ProprietarioModel();
            try
            {
                inq.fname = fname_textbox.Text.ToString();
                inq.lname = lname_textbox.Text.ToString();
                inq.telefone = Decimal.Parse(tel_textbox.Text.ToString());
                inq.id = Decimal.Parse(id_textBox.Text.ToString());
                inq.nif = Decimal.Parse(nif_textBox.Text.ToString());
                inq.morada = morada_text.Text.ToString();
                inq.ini = DateTime.Parse(dateTimePicker1.Text.ToString());
                inq.fim = DateTime.Parse(dateTimePicker2.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            saveInq(inq);
            MessageBox.Show("Entry Successful!");
            this.Close();
        }

        private void saveInq(ProprietarioModel inq)
        {
            data.connectToDB();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec inserirProp @fname, @lname, @telefone, @id, @nif, @morada, @data_ini, @data_fim";// "INSERT proj_pessoa (fname, lname, telefone, id, nif) values(@fname, @lname, @telefone, @id, @nif)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@lname", inq.lname);
            cmd.Parameters.AddWithValue("@fname", inq.fname);
            cmd.Parameters.AddWithValue("@telefone", inq.telefone);
            cmd.Parameters.AddWithValue("@id", inq.id);
            cmd.Parameters.AddWithValue("@nif", inq.nif);
            cmd.Parameters.AddWithValue("@morada", inq.morada);
            cmd.Parameters.AddWithValue("@data_ini", inq.ini);
            cmd.Parameters.AddWithValue("@data_fim", inq.fim);
            cmd.Connection = data.connection();


            try
            {
                cmd.ExecuteNonQuery();
                //cmd2.ExecuteNonQuery();
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
    }
}
