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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }
        private void casasBt_Click(object sender, EventArgs e)
        {
            navpanel.Controls.Clear();
            Casas casa = new Casas();
            casa.TopLevel = false;
            navpanel.Controls.Add(casa);
            casa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            casa.Show();
        }

        private void inquilinoBt_Click(object sender, EventArgs e)
        {
            navpanel.Controls.Clear();
            Form1 form1 = new Form1();
            form1.TopLevel = false;
            navpanel.Controls.Add(form1);
            form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form1.Show();

        }
    }
}
