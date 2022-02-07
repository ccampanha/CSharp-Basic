using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12_CalculoInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {   
                Console.WriteLine("ANO "+ contadorAno);
                Console.WriteLine("============================================");
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    Console.WriteLine("Após " + contadorMes + " mes(es) você terá R$" + valorInvestido);
                }
                fatorRendimento += 0.0010;
                Console.WriteLine("============================================");
                Console.WriteLine();
            }

            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
