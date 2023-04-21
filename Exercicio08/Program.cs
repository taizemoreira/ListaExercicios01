// Crie um programa para calcular o volume de uma lata de óleo
using System;

namespace CalculoVolumeLataDeOleo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CALCULANDO O VOLUME DA LATA\n\n   ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Por que a lata de óleo foi ao médico?\n" +
                "Porque estava se sentindo um pouco vazia por" +
                " dentro e queria saber qual era o seu volume!\n");
            Console.WriteLine();
            Console.ResetColor();

            double pi = 3.14;

            Console.Write("Por favor, informe o valor do raio da base da lata: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Por favor, informe o valor da altura da lata: ");
            double altura = double.Parse(Console.ReadLine());

            double volumeDaLata = pi * Math.Pow(raio, 2) * altura;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nO volume da lata de óleo é: " + volumeDaLata + "cm³");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}

