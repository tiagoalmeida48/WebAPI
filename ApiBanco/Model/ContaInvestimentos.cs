using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBanco.Model
{
    public class ContaInvestimentos : Conta
    {
        public double SacarDinheiroInvestimento(double valor)
        {
            return base.saldoInicial -= valor;
        }

        public double DepositarDinheiroInvestimento(double valor)
        {
            return base.saldoInicial += valor;
        }

        public double RenderJuros()
        {
            return base.saldoInicial += saldoInicial * 1.02;
        }

        public ContaInvestimentos RetornarCliente()
        {
            ContaInvestimentos cInvest = new ContaInvestimentos();
            ClientePF cliPF = new ClientePF();
            cliPF.nome = "Tiago Almeida";
            cInvest.ID = 1;
            cInvest.Cliente = cliPF;

            cInvest.numeroConta = 010589-5;
            cInvest.saldoInicial = 00223;
            return cInvest;
        }
        
        public List<ContaInvestimentos> ListarClientes()
        {
            List<ContaInvestimentos> listContas = new List<ContaInvestimentos>();
            listContas.Add(RetornarCliente());

            ContaInvestimentos cInvest1 = new ContaInvestimentos();
            ClientePF cliPF1 = new ClientePF();
            cliPF1.CPF = "877.778.877-88";
            cliPF1.nome = "Almeida";
            cInvest1.ID = 2;
            cInvest1.Cliente = cliPF1;

            cInvest1.numeroAgencia = 5875688;
            cInvest1.numeroConta = 11111;
            cInvest1.saldoInicial = 5000;

            listContas.Add(cInvest1);

            ContaInvestimentos cInvest2 = new ContaInvestimentos();
            ClientePF cliPF2 = new ClientePF();
            cliPF2.CPF = "555.555.588.98";
            cliPF2.nome = "Aparecido";

            cInvest2.ID = 3;
            cInvest2.Cliente = cliPF2;

            cInvest2.numeroAgencia = 1234;
            cInvest2.numeroConta = 569;
            cInvest2.saldoInicial = 10000;

            listContas.Add(cInvest2);

            return listContas;
        }
    }
}
