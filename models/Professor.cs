using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_C_.models
{
    public class Professor: Pessoa //se colocamos o sealed ele cela a classe e termina a herança aqui.
    {

        public Professor()
        {
            
        }

        public Professor(string nome): base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public sealed override void apresentar()
        {
            System.Console.WriteLine($"Olá sou o professor {nome} tenho {idade} anos e ganho {Salario}");
        }
    }
}