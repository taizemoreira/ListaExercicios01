//Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.
//Mostre a tabuada na forma:
//0 x N = 0,
//1 x N = 1N,
//2 x N = 2N, . . .
//10 x N = 10N.
using System;

namespace CalculaTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 10: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do {0}:", n);

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine("{0} x {1} = {2}", i, n, resultado);
            }

            Console.ReadLine();
        }
    }
}