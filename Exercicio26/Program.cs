// Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
//a.Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//b. Pesquise sobre “fatorial”
using System;

namespace CalculaFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor inteiro: ");
            int a = int.Parse(Console.ReadLine());
     
            int fatorial = 1;

            Console.Write("{0}! = ", a);

            for (int i = a; i >= 1; i--)
            {
                Console.Write("{0}", i);

                if (i != 1)
                {
                    Console.Write(" X ");
                }

                fatorial *= i;
            }

            Console.WriteLine(" = {0}", fatorial);

            Console.ReadLine();
        }
    }
}