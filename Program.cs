using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projetinho
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MySqlConnection conexao;
            conexao = new MySqlConnection("server=localhost;database=petshop;uid=root;password=vertrigo");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel conectar-se ao banco");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;

            string opcao;
            Menu menu = new Menu();
            Cliente c = new Cliente();
            Consulta con = new Consulta();
            Animal p = new Animal();
            string sql;

            do
            {
                opcao = menu.modoMenu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Cliente");
                        c.cadastrarCliente();                        
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar Pet");
                        p.cadastrarPet();                        
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Cadastrar Consulta");
                        con.CadastrarConsulta();                        
                        Console.ReadKey();
                        break;
                    case "4":
                        Veterinario vet = new Veterinario();
                        vet.cadastrarVet();                        
                        Console.ReadKey();
                        break;
                    case "5":
                        c.atualizarCliente();                        
                        Console.ReadKey();
                        break;
                    case "6":
                        con.atualizarConsulta();                                                
                        Console.ReadKey();
                        break;
                    case "7":
                        con.mostrarConsulta();                        
                        Console.ReadKey();
                        break;
                    case "8":
                        con.deletarConsulta();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        conexao.Close();
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != "Q");
        }
    }
}
