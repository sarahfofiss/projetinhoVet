using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Menu
    {

        public string modoMenu()
        {
            Console.Clear();
            Console.WriteLine("1 -Cadastrar Cliente");
            Console.WriteLine("2 -Cadastrar Pet");
            Console.WriteLine("3 -Cadastrar Consulta");
            Console.WriteLine("4 -Cadastrar Veterinario");
            Console.WriteLine("5 -Atualizar Cliente");
            Console.WriteLine("6 -Atualizar Consulta");
            Console.WriteLine("Q -Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}
