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
                        sql = "insert into cliente values(@nome, @cpf, @cep, @pet, @telefone, @email)";
                        cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@nome", c.nome);
                        cmd.Parameters.AddWithValue("@cpf", c.cpf);
                        cmd.Parameters.AddWithValue("@cep", c.cep);
                        cmd.Parameters.AddWithValue("@pet", c.pet);
                        cmd.Parameters.AddWithValue("@telefone", c.telefone);
                        cmd.Parameters.AddWithValue("@email", c.email);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar Pet");
                        p.cadastrarPet();
                        sql = "insert into animal values(@nome_pet, @tipo, @raca, @idade, @peso, @altura, @alergia, @id_pet)";
                        cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@nome_pet", p.nomepet);
                        cmd.Parameters.AddWithValue("@tipo", p.tipo);
                        cmd.Parameters.AddWithValue("@raca", p.raca);
                        cmd.Parameters.AddWithValue("@idade", p.idade);
                        cmd.Parameters.AddWithValue("@peso", p.peso);
                        cmd.Parameters.AddWithValue("@altura", p.altura);
                        cmd.Parameters.AddWithValue("@alergia", p.alergia);
                        cmd.Parameters.AddWithValue("@id_pet", p.id_pet);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Cadastrar Consulta");
                        con.CadastrarConsulta();
                        sql = "insert into consulta values(@data_consulta, @hora_consulta, @tipo_consulta, @valor, @id_consulta)";
                        cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@data_consulta", con.data_consulta);
                        cmd.Parameters.AddWithValue("@hora_consulta", con.hora_consulta);
                        cmd.Parameters.AddWithValue("@tipo_consulta", con.tipo_consulta);
                        cmd.Parameters.AddWithValue("@valor", con.valor);
                        cmd.Parameters.AddWithValue("@id_consulta", con.id_consulta);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        Console.ReadKey();
                        break;
                    case "4":
                        Veterinario vet = new Veterinario();
                        vet.cadastrarVet();
                        sql = "insert into veterinario values(@data_consulta, @nome, @cpf, @cep, @crmv, @telefone, @email, @especialidade)";
                        cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@nome", vet.nome);
                        cmd.Parameters.AddWithValue("@cpf", vet.cpf);
                        cmd.Parameters.AddWithValue("@cep", vet.cep);
                        cmd.Parameters.AddWithValue("@crmv", vet.crmv);
                        cmd.Parameters.AddWithValue("@telefone", vet.telefone);
                        cmd.Parameters.AddWithValue("@email", vet.email);
                        cmd.Parameters.AddWithValue("@especialidade", vet.especialidade);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        Console.ReadKey();
                        break;
                    case "5":
                        c.atualizarCliente();
                        sql = "update cliente set nome= @nome, cep= @cep, pet= @pet, telefone= @telefone, email= @email where cpf= @cpf";
                        cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@cpf", c.cpf);
                        cmd.Parameters.AddWithValue("@nome", c.nome);
                        cmd.Parameters.AddWithValue("@cep", c.cep);
                        cmd.Parameters.AddWithValue("@pet", c.pet);
                        cmd.Parameters.AddWithValue("@telefone", c.telefone);
                        cmd.Parameters.AddWithValue("@email", c.email);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        Console.ReadKey();
                        break;
                    case "6":
                        con.atualizarConsulta();
                        sql = "update consulta set data_consulta= @data_consulta, hora_consulta= @hora_consulta, tipo_consulta= @tipo_consulta, valor= @valor where id_consulta= @id_consulta";
                        cmd = new MySqlCommand(sql, conexao);
                        cmd.Parameters.AddWithValue("@id_consulta", con.id_consulta);
                        cmd.Parameters.AddWithValue("@data_consulta", con.data_consulta);
                        cmd.Parameters.AddWithValue("@hora_consulta", con.hora_consulta);
                        cmd.Parameters.AddWithValue("@tipo_consulta", con.tipo_consulta);
                        cmd.Parameters.AddWithValue("@valor", con.valor);
                        cmd.ExecuteNonQuery();
                        conexao.Close();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != "Q");
        }
    }
}
