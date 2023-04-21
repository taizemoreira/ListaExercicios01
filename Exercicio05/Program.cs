// Crie um programa para calcular o volume de uma esfera
using System;

namespace CalculoVolumeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************************************\n");
            Console.WriteLine("Bem-vindo ao programa de cálculo de volume da Esfera!\n");
            Console.WriteLine("*******************************************************\n");
            Console.ResetColor();

            //A fórmula para calcular o volume da esfera é: V = 4 · π · r³


            Console.Write("Por favor, insira a o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());


            double volume = 4 * Math.PI * raio * raio * raio;

            Console.WriteLine("\nO volume da esfera é de: " + volume);

            Console.ReadKey();
        }
    }
}
