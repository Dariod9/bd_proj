using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Proj.Models
{
    public class ContratoModel
    {
        public decimal codigo { get; set; }
        public DateTime data_ini { get; set; }
        public DateTime data_fim { get; set; }
        public int dia_pagamento { get; set; }
        public decimal proprietario { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
    }
}
