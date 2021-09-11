using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBanco.Model
{
    class ClientePF : Cliente
    {
        public string CPF { get; set; }
        public double renda { get; set; }
        public string sexo { get; set; }

    }
}
