using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            int idadeJoao = 16;
            int qtdPessoas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade, pode entrar");
            }
            else
            {
                if (qtdPessoas >= 2)
                    Console.WriteLine("João está acompanhado, pode entrar");
                else
                    Console.WriteLine("João é menor de idade, não pode entrar");
            }

            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
