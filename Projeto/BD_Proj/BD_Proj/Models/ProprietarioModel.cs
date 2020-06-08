using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proj
{
    public class ProprietarioModel : PessoaModel
    {
        public string morada { get; set; }
        public DateTime ini { get; set; }
        public DateTime fim { get; set; }
    }
}
