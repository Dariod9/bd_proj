using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace BD_Proj
{
    public class DataAccess
    {
        private static SqlConnection _cn;

        public void connectToDB()
        {
            _cn = new SqlConnection(Helper.CnnVal("p1g3_bd"));

            try
            {
                _cn.Open();
                if (_cn.State == ConnectionState.Open)
                {
                    //MessageBox.Show("Successful connection to database" + cn.Database + " on the " + cn.DataSource + " server", "Connection Test");
                }

            }
            catch (Exception execp)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR", "Connection Test");
            }
        }

        public void close()
        {
            _cn.Close();
        }

        public SqlConnection connection()
        {
            return _cn;
        }
    }
}
