using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projetinho
{
    class Animal
    {

        public string nomepet;
        public string tipo;
        public string raca;
        public double idade;
        public double peso;
        public double altura;
        public string alergia;
        public double id_pet;

        public void cadastrarPet()
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

            Console.WriteLine("Digite o nome do pet");
            nomepet = Console.ReadLine();
            Console.WriteLine("Digite o tipo de animal");
            tipo = Console.ReadLine();
            Console.WriteLine("Digite a raça");
            raca = Console.ReadLine();
            Console.WriteLine("Digite a idade");
            idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Possui alguma alergia? (s/n)");
            alergia = Console.ReadLine();
            if (alergia.ToLower().Equals("s"))
            {
                Console.WriteLine("Qual é a alergia?");
                alergia = Console.ReadLine();
            }

            string sql;
            sql = "insert into animal values(@nome_pet, @tipo, @raca, @idade, @peso, @altura, @alergia, @id_pet)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome_pet", nomepet);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@raca", raca);
            cmd.Parameters.AddWithValue("@idade", idade);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@altura", altura);
            cmd.Parameters.AddWithValue("@alergia", alergia);
            cmd.Parameters.AddWithValue("@id_pet", id_pet);
            cmd.ExecuteNonQuery();
        }
    }
}
