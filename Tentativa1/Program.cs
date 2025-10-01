using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tentativa1
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public bool Preferencial { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando um array de 3 posições
            Pessoa[] pessoas = new Pessoa[4];

            // Inicializando cada posição
            pessoas[0] = new Pessoa { Nome = "Ana", Idade = 25 };
            pessoas[1] = new Pessoa { Nome = "Carlos", Idade = 30 };
            pessoas[2] = new Pessoa { Nome = "Bruno", Idade = 20 };
            Console.WriteLine("Cadastre uma pessoa: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Preferencial: ");
            string Preferencial = (Console.ReadLine());
            bool tipo = false;
            if(Preferencial == "s")
            {
                tipo = true;
            }
            pessoas[3] = new Pessoa { Nome = Nome, Idade = Idade, Preferencial = tipo};
         

            // Percorrendo
            foreach (var p in pessoas)
            {
                if(p.Preferencial == true)
                {
                    Console.WriteLine($"{p.Nome} - Preferencial");
                }
            }
            foreach (var p in pessoas)
            {
                if(p.Preferencial == false)
                {
                    Console.WriteLine($"{p.Nome} - Comum");
                }
            }
        }
    }
}
