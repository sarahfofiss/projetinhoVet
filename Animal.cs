﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        /*public void atualizarPet()
        {
            Console.WriteLine("--- Recadastro de Pet ---");
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
            }*/
    }
}