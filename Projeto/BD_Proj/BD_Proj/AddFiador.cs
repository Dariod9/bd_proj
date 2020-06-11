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
            FiadorModel inq = new FiadorModel();
            try
            {
                inq.fname=fname_textbox.Text.ToString();
                inq.lname = lname_textbox.Text.ToString();
                inq.telefone = Decimal.Parse(tel_textbox.Text.ToString());
                inq.id = Decimal.Parse(id_textBox.Text.ToString());
                inq.nif = Decimal.Parse(nif_textBox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            saveInq(inq);
            this.Close();
        }

        private void saveInq(FiadorModel inq)
        {
            data.connectToDB();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec inserirFiador @fname, @lname, @telefone, @id, @nif";// "INSERT proj_pessoa (fname, lname, telefone, id, nif) values(@fname, @lname, @telefone, @id, @nif)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@lname", inq.lname);
            cmd.Parameters.AddWithValue("@fname", inq.fname);
            cmd.Parameters.AddWithValue("@telefone", inq.telefone);
            cmd.Parameters.AddWithValue("@id", inq.id);
            cmd.Parameters.AddWithValue("@nif", inq.nif);
           // cmd.Connection = data.connection();



            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.CommandText = "INSERT proj_fiador (nif) values(@nif)";
           // cmd2.Parameters.Clear();
            //cmd2.Parameters.AddWithValue("@nif", inq.nif);
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
