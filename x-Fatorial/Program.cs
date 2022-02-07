using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O fatorial de 0 é 1.
            //O fatorial de 1 é(0!) * 1 = 1.
            //O fatorial de 2 é(1!) * 2 = 2
            Console.WriteLine("Fatoriais de 0 a 10");

            int fatorial = 1;

            for (int n = 1; n<=10; n++)
            {
                fatorial *= n;
                Console.WriteLine(n + "! = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
