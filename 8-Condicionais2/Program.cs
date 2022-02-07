using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8");

            int idadeJoao = 16;
            int qtdPessoas = 2;
            bool acompanhado = qtdPessoas >= 2;

            // || => or
            // && => and
            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
               Console.WriteLine("João não pode entrar");
            }

            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
