﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 = Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2;
            Console.WriteLine(idade);
            
            
            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}