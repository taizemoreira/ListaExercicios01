// Escreva um programa que leia um número e imprima a sequência de Fibonacci até esse número.
using System;

namespace LerImprimirSeqFibinacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero inteiro qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.Write("{0} ", a);

            while (b <= numero)
            {
                Console.Write("{0} ", b);

                int temp = a + b;
                a = b;
                b = temp;
            }

            Console.ReadLine();
        }
    }
}