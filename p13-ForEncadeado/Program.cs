using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_ForEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13");

            for(int contadorLinha=1; contadorLinha <=10 ; contadorLinha++)
            {
                //Equivalente
                //for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                //{
                //    Console.Write("*");
                //}

                for (int contadorColuna = 0; contadorColuna <= 10; contadorColuna++)
                {
                    if (contadorColuna > contadorLinha)
                        break;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Outra forma de fazer
            for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
