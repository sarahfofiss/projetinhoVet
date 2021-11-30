using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projetinho
{
    class Consulta : Cliente
    {
        public double id_consulta;
        public DateTime data_consulta;
        public DateTime hora_consulta;
        public string tipo_consulta;
        public double valor;

        public void CadastrarConsulta()
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

            Console.WriteLine("Cadastrar Consulta");
            Console.WriteLine("Digite o tipo da consulta");
            tipo_consulta = Console.ReadLine();
            data_consulta = DateTime.Now;
            Console.WriteLine(data_consulta.Date);

            string sql;
            sql = "insert into consulta values(@data_consulta, @hora_consulta, @tipo_consulta, @valor, @id_consulta)";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@data_consulta", data_consulta);
            cmd.Parameters.AddWithValue("@hora_consulta", hora_consulta);
            cmd.Parameters.AddWithValue("@tipo_consulta", tipo_consulta);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@id_consulta", id_consulta);
            cmd.ExecuteNonQuery();
        }

        public void atualizarConsulta()
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

            Console.WriteLine("--- Recadastro ---");
            Console.WriteLine("Digite seu id:");
            id_consulta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo da consulta");
            tipo_consulta = Console.ReadLine();
            data_consulta = DateTime.Now;
            Console.WriteLine(data_consulta.Date);

            string sql;
            sql = "update consulta set data_consulta=@data_consulta, hora_consulta=@hora_consulta, tipo_consulta=@tipo_consulta, valor=@valor where id_consulta=@id_consulta";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id_consulta", id_consulta);
            cmd.Parameters.AddWithValue("@data_consulta", data_consulta);
            cmd.Parameters.AddWithValue("@hora_consulta", hora_consulta);
            cmd.Parameters.AddWithValue("@tipo_consulta", tipo_consulta);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.ExecuteNonQuery();
        }

        public void mostrarConsulta()
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

            Cliente c = new Cliente();

            Console.WriteLine("--- Consulta ---");
            Console.WriteLine("Digite seu id:");
            id_consulta = double.Parse(Console.ReadLine());
            
            string sqlselect = "select * from consulta where id_consulta=@id_consulta";
            cmd = new MySqlCommand(sqlselect, conexao);
            cmd.Parameters.AddWithValue("@id_consulta", id_consulta);
            cmd.CommandText = sqlselect;
            MySqlDataReader resultado = cmd.ExecuteReader();

            while (resultado.Read())
            {
                Console.WriteLine("id:" + resultado["id_consulta"]);
                Console.WriteLine("data da consulta:" + resultado["data_consulta"]);
                Console.WriteLine("tipo da consulta:" + resultado["tipo_consulta"]);
            }
        }
        public void deletarConsulta()
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
            
            Console.WriteLine("Digite o id da consulta que deseja apagar:");
            id_consulta = double.Parse(Console.ReadLine());

            string sqldelete = "delete from consulta where id_consulta=@id_consulta";
            cmd = new MySqlCommand(sqldelete, conexao);
            cmd.Parameters.AddWithValue("@id_consulta", id_consulta);
            cmd.CommandText = sqldelete;
            cmd.ExecuteNonQuery();
        }
    }
}
