using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_C_.models
{
    public class Pessoa
    {
        //estamos dando duas opções para construtor podendo ou nao passar os parametros
        //Todo construtos é herdado 

        public Pessoa()
        {
            
        }

        public Pessoa(string nome)
        {
            nome = nome;
        }


        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }

        public virtual void apresentar(){
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }
    }
}