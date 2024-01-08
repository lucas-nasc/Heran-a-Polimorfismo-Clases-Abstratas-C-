using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_C_.models
{
    public class ContaCorrente
    {
        public ContaCorrente(int NumeroConta, decimal saldoInicial)
        {
            NumeroConta = NumeroConta;
            saldo = saldoInicial;
        }



        public int NumeroConta { get; set; }
        private decimal saldo;
 
        public void Sacar(decimal valor)
        {
            if(saldo >= valor){
                 saldo -= valor;
                 System.Console.WriteLine("Saque realizado com sucesso ");
            }else{
                System.Console.WriteLine("O valor é maior que o saldo disponivel");
            }
           
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public void ExibirSaldo(){
            System.Console.WriteLine("Seu saldo disponivel é de " + saldo);
        }


    }
}