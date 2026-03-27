using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Web;

namespace _01_FUNDAMETOS.Models
{
    public class Pessoa
    {
        public String Nome  { get; set; }
        public int Idade { get; set; }
        public String cpf { get; set; }
        

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
            Console.WriteLine($"Meu CPF é {cpf}");
            //Console.WriteLine($"Olá, meu nome é {Nome} \n e tenho {Idade} anos.");

        }
        
    }
}