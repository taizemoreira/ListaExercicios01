//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
using System;

namespace OrdemDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" leia três valores inteiros");
            Console.ResetColor();

            // Leitura dos valores 
            Console.Write("Digite o valor de A: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int valorC = int.Parse(Console.ReadLine());

            // Verifica qual é maior
            int valorMaior = valorA;

            if (valorB > valorMaior)
            {
                valorMaior = valorB;
            }

            if (valorC > valorMaior)
            {
                valorMaior = valorC;
            }

            int valorMenor = valorA;

            if (valorB < valorMenor)
            {
                valorMenor = valorB;
            }

            if (valorC < valorMenor)
            {
                valorMenor = valorC;
            }

            int valorMedio = (valorA + valorB + valorC) - valorMaior - valorMenor;

            Console.WriteLine("Valores em ordem decrescente: {0}, {1}, {2}", valorMaior, valorMedio, valorMenor);

            Console.ReadLine();
        }
    }
}


