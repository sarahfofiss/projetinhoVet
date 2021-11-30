using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projetinho
{
    public class Cliente
    {
        public string nome;
        public double cpf;
        public double cep;
        public string pet;
        public double telefone;
        public string email;

        public void cadastrarCliente()
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

            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu Pet");
            pet = Console.ReadLine();
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();

            string sql;
            sql = "insert into cliente values(@nome, @cpf, @cep, @pet, @telefone, @email)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@pet", pet);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
        }

        public void atualizarCliente()
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

            Console.WriteLine("--- Recadastro de Cliente ---");
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do seu Pet");
            pet = Console.ReadLine();
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();

            string sql;
            sql = "update cliente set nome=@nome, cep=@cep, pet=@pet, telefone=@telefone, email=@email where cpf=@cpf";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@pet", pet);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();
        }
    }
}
