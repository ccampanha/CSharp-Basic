using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");
            double salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario; //Esta conversão de tipo se chama CASTING
            Console.WriteLine(salarioEmInteiro);

            //o long é uma variavel de 64 bits
            long idade = 13000000000000;
            Console.WriteLine(idade);

            //o short é uma variavel se 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);       

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();

        }
    }
}
