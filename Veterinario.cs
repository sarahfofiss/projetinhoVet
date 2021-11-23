using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Veterinario
    {
        public string nome;
        public double cpf;
        public double cep;
        public double crmv;
        public double telefone;
        public string email;
        public string especialidade;


        public void cadastrarVet()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua CRMV");
            crmv = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();
            Console.WriteLine("Digite sua especialidade");
            especialidade = Console.ReadLine();
        }
    }
}