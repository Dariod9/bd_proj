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
    public partial class EmpInfo : Form
    {
        DataAccess data = new DataAccess();
        public EmpInfo()
        {
            InitializeComponent();
            fillEmpresaslistbox();
            listBox1.SelectedValueChanged += new EventHandler(listBox1_SelectedValueChanged);

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            data.connectToDB();
            String sql = "SELECT * FROM proj_empresa where nome='" + empresa_selected() + "'";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();

            name_textBox.Text = reader.GetString(0);
            nif_textBox.Text = "" + reader.GetDecimal(1);
            mail_textBox.Text = reader.GetString(2);
            contact_textBox.Text = ""+reader.GetDecimal(3);

            data.close();
        }

        private string empresa_selected()
        {
            return listBox1.SelectedItem.ToString();
        }

        public void fillEmpresaslistbox()
        {
            listBox1.DataSource = GetEmpresas();
        }
        private void fillEmpresaslistbox(List<String> lista)
        {
            listBox1.DataSource = lista;
        }

        private List<String> GetEmpresas()
        {
            List<String> c = new List<String>();

            data.connectToDB();
            String sql = "SELECT * FROM nomesEmpresas";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                c.Add(reader.GetString(0));
            }
            data.close();

            return c;
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            if (search_textBox.Text == "")
            {
                fillEmpresaslistbox();
            }
            else
            {
                var a = GetEmpresas();

                fillEmpresaslistbox(a.Where(x => x.ToLower().Contains(search_textBox.Text.ToLower())).ToList());
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            AddEmpresa add = new AddEmpresa(getEmpresa(empresa_selected()));
            add.ShowDialog(this);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddEmpresa add = new AddEmpresa();
            add.ShowDialog(this);
        }

        private EmpresaModel getEmpresa(string nome)
        {
            data.connectToDB();
            String sql = "SELECT nif, email, contacto FROM proj_empresa where nome='" + nome + "'";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            EmpresaModel c = new EmpresaModel();
            c.nome = nome;
            c.nif = reader.GetDecimal(0);
            c.email = reader.GetString(1);
            c.contacto = reader.GetDecimal(2);
            reader.Close();
            data.close();
            return c;
        }
    }
}
