using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Consulta
    {
        public double id_consulta;
        public DateTime data_consulta;
        public DateTime hora_consulta;
        public string tipo_consulta;
        public double valor;

        public void CadastrarConsulta()
        {
            Console.WriteLine("Cadastrar Consulta");
            Console.WriteLine("Digite o tipo da consulta");
            tipo_consulta = Console.ReadLine();
            data_consulta = DateTime.Now;
            Console.WriteLine(data_consulta.Date);
        }

        public void atualizarConsulta()
        {
            Console.WriteLine("--- Recadastro ---");
            Console.WriteLine("Digite seu id:");
            id_consulta = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo da consulta");
            tipo_consulta = Console.ReadLine();
            data_consulta = DateTime.Now;
            Console.WriteLine(data_consulta.Date);
        }
    }
}