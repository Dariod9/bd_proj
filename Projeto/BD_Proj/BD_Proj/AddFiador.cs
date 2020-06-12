using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Proj
{
    public partial class AddFiador : Form
    {
        DataAccess data = new DataAccess();

        public AddFiador()
        {
            InitializeComponent();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_bt_Click(object sender, EventArgs e)
        {
            FiadorModel fiador = new FiadorModel();
            try
            {
                fiador.fname=fname_textbox.Text.ToString();
                fiador.lname = lname_textbox.Text.ToString();
                fiador.telefone = Decimal.Parse(tel_textbox.Text.ToString());
                fiador.id = Decimal.Parse(id_textBox.Text.ToString());
                fiador.nif = Decimal.Parse(nif_textBox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            savefiador(fiador);
            addContratoRenda parent = (addContratoRenda) Owner;
            parent.FillFiadorBox();
            this.Close();
        }

        private void savefiador(FiadorModel fiador)
        {
            data.connectToDB();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec inserirFiador @fname, @lname, @telefone, @id, @nif";// "INSERT proj_pessoa (fname, lname, telefone, id, nif) values(@fname, @lname, @telefone, @id, @nif)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@lname", fiador.lname);
            cmd.Parameters.AddWithValue("@fname", fiador.fname);
            cmd.Parameters.AddWithValue("@telefone", fiador.telefone);
            cmd.Parameters.AddWithValue("@id", fiador.id);
            cmd.Parameters.AddWithValue("@nif", fiador.nif);
           // cmd.Connection = data.connection();



            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.CommandText = "INSERT proj_fiador (nif) values(@nif)";
           // cmd2.Parameters.Clear();
            //cmd2.Parameters.AddWithValue("@nif", fiador.nif);
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
               // DadosPessoais.printFiadores();
            }
        }
    }
}
