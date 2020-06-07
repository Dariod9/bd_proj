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
    public partial class AddInquilino : Form
    {
        DataAccess data = new DataAccess();
        //bool mor;
        //string moradaGlobal;

        public AddInquilino()
        {
            InitializeComponent();
            fillMoradaBox();
          //  mor = false;
        }

        public AddInquilino(string morada)
        {
            InitializeComponent();
            morada_box.Text = morada;
        }

        private void fillMoradaBox()
        {
            List<String> conds = new List<String>();

            data.connectToDB();
            String sql = "SELECT DISTINCT morada FROM Moradas";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                morada_box.Items.Add(reader.GetString(0));
            }
            data.close();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_bt_Click(object sender, EventArgs e)
        {
            InquilinoModel inq = new InquilinoModel();
            try
            {
                inq.fname=fname_textbox.Text.ToString();
                inq.lname = lname_textbox.Text.ToString();
                inq.telefone = Decimal.Parse(tel_textbox.Text.ToString());
                inq.id = Decimal.Parse(id_textBox.Text.ToString());
                inq.nif = Decimal.Parse(nif_textBox.Text.ToString());
                inq.certificado = cert_textBox.Text.ToString();
                inq.reg_criminal = reg_textBox.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            saveInq(inq);
            MessageBox.Show("Entry Successful!");
            this.Close();
        }

        private void saveInq(InquilinoModel inq)
        {
            data.connectToDB();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "exec inserirInq @fname, @lname, @telefone, @id, @nif, @certificado, @reg_criminal, @morada";// INSERT proj_pessoa (fname, lname, telefone, id, nif) values(@fname, @lname, @telefone, @id, @nif)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@lname", inq.lname);
            cmd.Parameters.AddWithValue("@fname", inq.fname);
            cmd.Parameters.AddWithValue("@telefone", inq.telefone);
            cmd.Parameters.AddWithValue("@id", inq.id);
            cmd.Parameters.AddWithValue("@nif", inq.nif);
           // cmd.Connection = data.connection();



            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.CommandText = "INSERT proj_inquilino (nif, certificado, reg_criminal) values(@nif, @certificado, @reg_criminal)";
            //cmd2.Parameters.Clear();
            //cmd2.Parameters.AddWithValue("@nif", inq.nif);
            cmd.Parameters.AddWithValue("@certificado", inq.certificado);
            cmd.Parameters.AddWithValue("@reg_criminal", inq.reg_criminal);
            cmd.Parameters.AddWithValue("@morada", morada_box.Text);
            cmd.Connection = data.connection();

            //if (mor)
            //{
            //    SqlCommand cmd2 = new SqlCommand();
            //    cmd2.CommandText = "Insert into proj_casa_inquilino (nif, morada) values( @nif, @morada)";
            //    cmd2.Parameters.AddWithValue("@nif", inq.nif);
            //    cmd2.Parameters.AddWithValue("@morada", moradaGlobal);
            //}


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
               // DadosPessoais.printInquilinos();

            }
        }

        private void AddCasa_Load(object sender, EventArgs e)
        {

        }

        private void condominio_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void n_quartos_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void morada_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCasa_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
