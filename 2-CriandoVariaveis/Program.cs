﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 2 - Criando Variaveis!");

            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = idade + 10;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade);

            Console.WriteLine("Execução finalizada. Tecle <Enter> para sair . . .");
            Console.ReadLine();
        }
    }
}
