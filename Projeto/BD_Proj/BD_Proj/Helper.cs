using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proj
{
    public class Helper
    {
        public static string CnnVal(string bd_name)
        {
            return ConfigurationManager.ConnectionStrings[bd_name].ConnectionString;
        }
    }
}
