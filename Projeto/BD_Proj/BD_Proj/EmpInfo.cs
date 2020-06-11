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
            FillEmpresaLisBox();
            listBox1.SelectedValueChanged += new EventHandler(listBox1_SelectedValueChanged);

        }

        private void FillEmpresaInfo(EmpresaModel emp)
        {
            name_textBox.Text = emp.nome;
            nif_textBox.Text = emp.nif.ToString();
            mail_textBox.Text = emp.email;
            contact_textBox.Text = emp.contacto.ToString();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FillEmpresaInfo(GetEmpresaInfo(empresa_selected()));
        }

        private EmpresaModel GetEmpresaInfo(decimal nif)
        {
            data.connectToDB();
            SqlCommand com = new SqlCommand("getEmpresaByNif", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nif", empresa_selected());

            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();

            EmpresaModel emp = new EmpresaModel();
            emp.nif = empresa_selected();
            emp.nome = reader["nome"].ToString();
            emp.contacto = Decimal.Parse(reader["contacto"].ToString());
            emp.email = reader["email"].ToString();

            data.close();

            return emp;
        }

        private decimal empresa_selected()
        {
            return (listBox1.SelectedItem as EmpresaView).value;
        }

        //public void fillEmpresaslistbox()
        //{
        //    listBox1.DataSource = GetEmpresas();
        //}

        //private List<String> GetEmpresas()
        //{
        //    List<String> c = new List<String>();

        //    data.connectToDB();
        //    String sql = "SELECT * FROM nomesEmpresas";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        c.Add(reader.GetString(0));
        //    }
        //    data.close();

        //    return c;
        //}


        public void FillEmpresaLisBox()
        {
            listBox1.DataSource = GetEmpresas();
            listBox1.DisplayMember = "text";
            listBox1.ValueMember = "value";
        }

        private List<EmpresaView> GetEmpresas()
        {
            List<EmpresaView> e = new List<EmpresaView>();

            data.connectToDB();
            String sql = "SELECT * FROM Show_Empresas";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                EmpresaView ee = new EmpresaView();
                ee.value = Decimal.Parse(reader["nif"].ToString());
                ee.text = reader["nome"].ToString();

                e.Add(ee);
            }
            data.close();

            return e;
        }

        private void FillEmpresaLisBox(List<EmpresaView> lista)
        {
            listBox1.DataSource = lista;
            listBox1.DisplayMember = "text";
            listBox1.ValueMember = "value";
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            if (search_textBox.Text == "")
            {
                FillEmpresaLisBox();
            }
            else
            {
                var a = GetEmpresas();

                FillEmpresaLisBox(a.Where(x => x.ToLower().Contains(search_textBox.Text.ToLower())).ToList());
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            AddEmpresa add = new AddEmpresa(GetEmpresaInfo(empresa_selected()));
            add.ShowDialog(this);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            AddEmpresa add = new AddEmpresa();
            add.ShowDialog(this);
        }

        //private EmpresaModel getEmpresa(string nome)
        //{
        //    data.connectToDB();
        //    String sql = "SELECT nif, email, contacto FROM proj_empresa where nome='" + nome + "'"; 
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    reader.Read();
        //    EmpresaModel c = new EmpresaModel();
        //    c.nome = nome;
        //    c.nif = reader.GetDecimal(0);
        //    c.email = reader.GetString(1);
        //    c.contacto = reader.GetDecimal(2);
        //    reader.Close();
        //    data.close();
        //    return c;
        //}
    }
}
