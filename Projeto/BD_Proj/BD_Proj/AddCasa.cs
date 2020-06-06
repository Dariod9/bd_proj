﻿using System;
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
        private bool adding;

        public AddCasa()
        {
            InitializeComponent();
            FillCondominioComboBox();
            adding = true;      // insert
        }

        public AddCasa(CasaModel c)
        {
            InitializeComponent();
            FillCondominioComboBox();
            FillCasaInformation(c);
            adding = false;     // update
        }

        private void FillCasaInformation(CasaModel c)
        {
            morada_textbox.Text = c.morada;
            morada_textbox.ReadOnly = true;
            cidade_textbox.Text = c.cidade;
            descricao_textbox.Text = c.descricao;
            n_quartos_comboBox.Text = c.n_quartos.ToString();
            max_hab_comboBox.Text = c.max_hab.ToString();
            condominio_comboBox.Text = c.condominio.ToString();
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
                casa.n_quartos = Int32.Parse(n_quartos_comboBox.Text.ToString());
                casa.max_hab = Int32.Parse(max_hab_comboBox.Text.ToString());
                casa.condominio = getNIF(condominio_comboBox.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (adding)
            {
                saveCasa(casa);
                MessageBox.Show("Entry Successful!");
            }
            else
            {
                UpdateCasa(casa);
                MessageBox.Show("Update Successful!");
            }

            Navigation parent = (Navigation) Owner;
            parent.ShowCasas();
            this.Close();
        }

        private void saveCasa(CasaModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "INSERT proj_casa (morada, n_quartos, cidade, max_hab, descricao, condominio) Values(@morada, @n_quartos, @cidade, @max_hab, @descricao, @condominio)";
            cmd.CommandText = "EXEC inserirCasa @morada, @n_quartos, @cidade, @max_hab, @descricao, @condominio";
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

        private void UpdateCasa(CasaModel c)
        {
            data.connectToDB();

            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "UPDATE proj_casa SET n_quartos = @n_quartos, "
            //                + "cidade = @cidade, max_hab = @max_hab, descricao = @descricao, "
            //                + "condominio = @condominio WHERE morada = @morada";
            cmd.CommandText = "EXEC updateCasa @morada, @n_quartos, @cidade, @max_hab, @descricao, @condominio";
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
                throw new Exception("Failed to update in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                data.close();
            }
        }

        private void FillCondominioComboBox()
        {
            List<Decimal> conds = new List<Decimal>();

            data.connectToDB();
            String sql = "SELECT DISTINCT nome FROM proj_condominio";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                condominio_comboBox.Items.Add(reader.GetString(0));
            }
            data.close();
        }

        private decimal getNIF(string cond)
        {
            data.connectToDB();
            //String sql = "SELECT num_fiscal FROM proj_condominio where nome='"+cond+"' ";
            SqlCommand com = new SqlCommand("getNumFiscalCond", data.connection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nome", cond);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            reader.Read();
            var a = reader.GetDecimal(0);
            reader.Close();
            data.close();
            return a;
        }
    }
}
