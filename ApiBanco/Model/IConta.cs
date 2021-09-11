using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBanco.Model
{
    interface IConta
    {
        double SacarDinheiro(double valor);

        double DepositarDinheiro(double valor);
    }
}
