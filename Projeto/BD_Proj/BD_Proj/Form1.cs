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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectToDB()
        {
            SqlConnection cn = new SqlConnection(Helper.CnnVal("p1g3_bd"));

            try
            {
                cn.Open();
                if (cn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database" + cn.Database + " on the " + cn.DataSource + " server", "Connection Test");

                }

            }
            catch (Exception execp)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR", "Connection Test");
            }
        }

        private void cnn_bt_Click(object sender, EventArgs e)
        {
            connectToDB();
        }
    }
}
