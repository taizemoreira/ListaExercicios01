using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios01.Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            int fib1 = 0, fib2 = 1;

            Console.Write(fib1 + " " + fib2 + " ");

            while (fib2 < numeroDigitado)
            {
                int fib3 = fib1 + fib2;
                Console.Write(fib3 + " ");
                fib1 = fib2;
                fib2 = fib3;
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}