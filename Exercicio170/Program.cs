// Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
using System;

namespace AlgoritmoLerValores
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Praticando Estruturas de Decisão");

            // Leitura dos valores A, B e C
            Console.Write("Digite o valor de A: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int valorB = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int valorC = int.Parse(Console.ReadLine());

            // Verifica se a soma de A e B é menor que C
            if (valorA + valorB < valorC)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior ou igual a C.");
            }
        }
    }
}

