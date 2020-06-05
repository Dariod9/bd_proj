using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proj.Models
{
    public class ContratoRendaModel
    {
        public decimal codigo { get; set; }
        public DateTime data_ini { get; set; }
        public DateTime data_fim { get; set; }
        public int dia_pagamento { get; set; }
        public decimal proprietario { get; set; }
        public int renda { get; set; }
        public int caucao { get; set; }
        public int taxa { get; set; }
        public string n_renda { get; set; }
        public decimal fiador { get; set; }
        public decimal inquilino { get; set; }
        public decimal empresa { get; set; }
    }
}
