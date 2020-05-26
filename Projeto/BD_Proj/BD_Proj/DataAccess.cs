using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BD_Proj
{
    public class DataAccess
    {
        public static SqlConnection cn;

        public void connectToDB()
        {
            cn = new SqlConnection(Helper.CnnVal("p1g3_bd"));

            try
            {
                cn.Open();
                if (cn.State == ConnectionState.Open)
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
            cn.Close();
        }

        public SqlConnection connection()
        {
            return cn;
        }
    }
}
