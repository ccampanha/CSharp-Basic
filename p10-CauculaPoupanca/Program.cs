using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10_CalculaPoupanca_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 1");

            double valorInvestido = 1000;
            int contadorMes = 0;

            while (contadorMes < 12)
            {
                contadorMes++;
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " mes(es) você terá R$" + valorInvestido);  
            }
            
            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
