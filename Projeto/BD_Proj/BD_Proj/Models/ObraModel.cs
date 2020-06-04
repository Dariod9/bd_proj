using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proj.Models
{
    public class ObraModel
    {
        public int obra_id { get; set; }
        public DateTime data_ini { get; set; }
        public DateTime data_fim { get; set; }
        public int orcamento { get; set; }
        public decimal condominio { get; set; }
    }
}
