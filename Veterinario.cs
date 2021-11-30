using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

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

            string sql;
            sql = "insert into veterinario values(@data_consulta, @nome, @cpf, @cep, @crmv, @telefone, @email, @especialidade)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@crmv", crmv);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@especialidade", especialidade);
            cmd.ExecuteNonQuery();
        }
    }
}
