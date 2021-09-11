using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBanco.Model
{
    public abstract class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dtNascFunc { get; set; }
        public string email { get; set; }
        public string endereco{ get; set; }
        public string documento { get; set; }

    }
}
