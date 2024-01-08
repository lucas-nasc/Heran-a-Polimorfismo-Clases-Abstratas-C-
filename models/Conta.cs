using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_C_.models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
            {
                System.Console.WriteLine("seu saldo é " + saldo);
            }
    }
}