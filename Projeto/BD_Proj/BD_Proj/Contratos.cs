﻿using BD_Proj.Models;
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
    public partial class Contratos : Form
    {
        DataAccess data = new DataAccess();
        public Contratos()
        {
            InitializeComponent();
            fillDataGrid();
        }

        //private void Fill_listbox()
        //{
        //    data.connectToDB();
        //    String sql = "SELECT morada FROM proj_contratos";
        //    SqlCommand com = new SqlCommand(sql, data.connection());
        //    SqlDataReader reader;
        //    reader = com.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        pessoas_listBox.Items.Add(reader.GetValue(0));
        //    }
        //    data.close();
        //}

        private List<ContratoModel> GetContratos()
        {
            data.connectToDB();

            List<ContratoModel> pessoas = new List<ContratoModel>();

            String sql = "SELECT * FROM proj_contrato join proj_pessoa on proj_contrato.proprietario=proj_pessoa.nif";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ContratoModel tmp = new ContratoModel();

                tmp.codigo = reader.GetDecimal(0);
                tmp.data_ini = reader.GetDateTime(1);
                tmp.data_fim = reader.GetDateTime(2);
                tmp.dia_pagamento= reader.GetInt32(3);
                tmp.proprietario= reader.GetDecimal(4);
                tmp.fname = reader.GetString(5);
                tmp.lname = reader.GetString(6);

                pessoas.Add(tmp);
            }
            data.close();

            return pessoas;
        }

        private void fillDataGrid()
        {
            pessoa_dataGrid.DataSource = GetContratos();
          //  pessoa_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            //pessoa_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";
        }

        private void fillDataGrid(List<ContratoModel> lista)
        {
            pessoa_dataGrid.DataSource = lista ;
            //  pessoa_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            //pessoa_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";
        }

        private void pessoa_bt_Click(object sender, EventArgs e)
        {
            addContrato add = new addContrato();
            add.ShowDialog();
        }

        private void DadosPessoais_Load(object sender, EventArgs e)
        {

        }

        public List<ContratoRendaModel> printRendas()
        {
            data.connectToDB();

            List<ContratoRendaModel> rendas = new List<ContratoRendaModel>();

            String sql = "SELECT * FROM ((proj_contrato join proj_pessoa on proj_contrato.proprietario=proj_pessoa.nif) join proj_contrato_renda on proj_contrato.codigo=proj_contrato_renda.codigo)";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ContratoRendaModel tmp = new ContratoRendaModel();

                tmp.codigo = reader.GetDecimal(0);
                tmp.data_ini = reader.GetDateTime(1);
                tmp.data_fim = reader.GetDateTime(2);
                tmp.dia_pagamento = reader.GetInt32(3);
                tmp.proprietario = reader.GetDecimal(4);
                tmp.renda = reader.GetInt32(8);
                tmp.caucao= reader.GetInt32(9);
                tmp.taxa= reader.GetInt32(10);
                tmp.fiador= reader.GetDecimal(11);
                tmp.inquilino= reader.GetDecimal(12);
                tmp.empresa= reader.GetDecimal(13);


                rendas.Add(tmp);
            }
            data.close();
            return rendas;
        }

        private void FillRendas()
        {
            pessoa_dataGrid.DataSource = printRendas();
            //  pessoa_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            //pessoa_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";
        }

        private void FillCondos()
        {
            pessoa_dataGrid.DataSource = printCondos();
            //  pessoa_dataGrid.Columns["n_quartos"].HeaderText = "Número de quartos";
            //pessoa_dataGrid.Columns["max_hab"].HeaderText = "N máximo de habitantes";
        }



        public List<ContratoCondominioModel> printCondos()
        {
            data.connectToDB();

            List<ContratoCondominioModel> conds = new List<ContratoCondominioModel>();

            String sql = "SELECT * FROM ((proj_contrato join proj_pessoa on proj_contrato.proprietario=proj_pessoa.nif) join proj_contrato_condominio on proj_contrato.codigo=proj_contrato_condominio.codigo)";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ContratoCondominioModel tmp = new ContratoCondominioModel();

                tmp.codigo = reader.GetDecimal(0);
                tmp.data_ini = reader.GetDateTime(1);
                tmp.data_fim = reader.GetDateTime(2);
                tmp.dia_pagamento = reader.GetInt32(3);
                tmp.proprietario = reader.GetDecimal(4);
                tmp.despesas = reader.GetInt32(8);
                tmp.seguro = reader.GetString(9);
                tmp.area = reader.GetInt32(10);
                tmp.condominio = reader.GetDecimal(11);


                conds.Add(tmp);
            }
            data.close();
            return conds;
        }

       private object contrato_selected()
        {
            return pessoa_dataGrid.SelectedRows;
        }

        private void rendas_Click(object sender, EventArgs e)
        {
            FillRendas();
        }

        private void cnodos_Click(object sender, EventArgs e)
        {
            FillCondos();
        }

        private void pessoa_textBox_TextChanged(object sender, EventArgs e)
        {
            data.connectToDB();

            List<ContratoModel> pessoas = new List<ContratoModel>();

            String sql = "SELECT * FROM proj_contrato join proj_pessoa on proj_contrato.proprietario=proj_pessoa.nif";
            SqlCommand com = new SqlCommand(sql, data.connection());
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                ContratoModel tmp = new ContratoModel();

                tmp.codigo = reader.GetDecimal(0);
                tmp.data_ini = reader.GetDateTime(1);
                tmp.data_fim = reader.GetDateTime(2);
                tmp.dia_pagamento = reader.GetInt32(3);
                tmp.proprietario = reader.GetDecimal(4);
                tmp.fname = reader.GetString(5);
                tmp.lname = reader.GetString(6);

                pessoas.Add(tmp);
            }
            data.close();
            fillDataGrid(pessoas.Where(x => x.fname.ToLower().Contains(pessoa_textBox.Text.ToLower()) || x.lname.ToLower().Contains(pessoa_textBox.Text.ToLower())).ToList());
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            //var a= contrato_selected();
        }
    }
}
