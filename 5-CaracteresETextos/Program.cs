using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            //Para somar um int tem que fazer um casting para char
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string Titulo = "Alura Cursos de Tecnologia ";
            Console.WriteLine(Titulo);

            //Se somar um numero na string, converte o numero
            //em stringautomaticamente
            Titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(Titulo);

            //Não considera o enter
            string cursosProgramacao = "Cursos de Programação:" +
                "- .Net" +
                "- Java" +
                "- Javascript";

            Console.WriteLine(cursosProgramacao);
            Console.WriteLine("");

            //colocando o @ considera tudo, inclusive os espaços em branco
            cursosProgramacao = @"Cursos de Programação:
             - .Net
             - Java
             - Javascript";

            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("");
            Console.WriteLine("A execução acabou, tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
