using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBanco.Model
{
    public class Conta : IConta
    {
        public int ID { get; set; }
        public int numeroAgencia { get; set; }
        public int numeroConta { get; set; }
        public int numeroBanco { get; set; }
        public Cliente Cliente { get; set; }
        public double saldoInicial { get; set; }
        public double saldoAtual { get; set; }

        public double SacarDinheiro(double valor) {
            return 0;
        }

        public double DepositarDinheiro(double valor) {
            return 0;
        }

    }
}
