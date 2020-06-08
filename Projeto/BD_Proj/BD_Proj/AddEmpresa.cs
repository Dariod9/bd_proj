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
    public partial class AddEmpresa : Form
    {
        DataAccess data = new DataAccess();
        private bool adding;
        public AddEmpresa()
        {
            InitializeComponent();
            adding = true;      // insert
        }

        public AddEmpresa(EmpresaModel emp)
        {
            InitializeComponent();
            FillEmpresaInfo(emp);
            adding = false;      // insert
        }

        private void FillEmpresaInfo(EmpresaModel e)
        {
            nome_textBox.Text = e.nome;
            nif_textBox.Text = e.nif.ToString();
            nif_textBox.ReadOnly = true;
            email_textBox.Text = e.email;
            contacto_textBox.Text = e.contacto.ToString();
        }

        private void cancel_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            EmpresaModel empresa = new EmpresaModel();
            try
            {
                empresa.nome = nome_textBox.Text;
                empresa.nif = Decimal.Parse(nif_textBox.Text.ToString());
                empresa.email = email_textBox.Text;
                empresa.contacto = Decimal.Parse(contacto_textBox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adding)
            {
                SaveEmpresa(empresa);
                MessageBox.Show("Entry Successful!");
            }
            else
            {
                UpdateEmpresa(empresa);
                MessageBox.Show("Update Successful!");
            }

            EmpInfo parent = (EmpInfo)Owner;
            parent.fillEmpresaslistbox();
            this.Close();
        }

        private void SaveEmpresa(EmpresaModel e)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "INSERT proj_empresa (nome, nif, email, contacto) Values(@nome, @nif, @email, @contacto)";
            cmd.CommandText = "EXEC insertEmpresa @nome, @nif, @email, @contacto";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", e.nome);
            cmd.Parameters.AddWithValue("@nif", e.nif);
            cmd.Parameters.AddWithValue("@email", e.email);
            cmd.Parameters.AddWithValue("@contacto", e.contacto);
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

        private void UpdateEmpresa(EmpresaModel e)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "UPDATE proj_empresa SET nome = @nome, "
            //                + "email = @email, contacto = @contacto "
            //                + "WHERE nif = @nif";
            cmd.CommandText = "EXEC updateEmpresa @nome, @nif, @email, @contacto";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nome", e.nome);
            cmd.Parameters.AddWithValue("@nif", e.nif);
            cmd.Parameters.AddWithValue("@email", e.email);
            cmd.Parameters.AddWithValue("@contacto", e.contacto);
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
