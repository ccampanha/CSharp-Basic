using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8");

            int idadeJoao = 16;
            int qtdPessoas = 1;
            bool acompanhado = qtdPessoas >= 2;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }

            // || => or
            // && => and
            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar!");
                if (!acompanhado)
                    Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
