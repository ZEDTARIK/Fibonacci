using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static int p1 = 0, p2 = 1, p3;

        static void Main(string[] args)
        {
            Console.Write("Pealse enter the Number (Fibonacci) : ");
            int nbFibonacci = int.Parse(Console.ReadLine());

            Console.Write(p1 + " " + p2);
            //for(int i=2; i<nbFibonacci; i++)
            //{
            //    p3 = p2 + p1;
            //    Console.Write(" " + p3);
            //    p1 = p2;
            //    p2 = p3;
            //}

            Fibonacci(nbFibonacci - 2);
            Console.WriteLine();

            Console.ReadKey();
        }

        private static void Fibonacci(int nbFibonacci)
        {
            if(nbFibonacci > 0)
            {
                p3 = p2 + p1;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;

                Fibonacci(nbFibonacci - 1);
            }
        }
    }
}
