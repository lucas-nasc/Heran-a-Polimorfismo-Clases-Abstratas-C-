using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_C_.models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome): base(nome)
        {
            
        }


        public double Nota { get; set; }

        public override void apresentar()
        {
            System.Console.WriteLine($"Ola meu nome é {nome}, tenho {idade} e sou um aluno nota {Nota}");
        }

    }
}