// Crie um programa para calcular o volume de um Cilindro
using System;

namespace CalculoVolumeCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************************************\n");
            Console.WriteLine("Bem-vindo ao programa de cálculo de volume do Cilindro!\n");
            Console.WriteLine("*******************************************************\n");
            Console.ResetColor();

            //A fórmula para calcular o volume de um cilindro é: V = π * r ^ 2 * h


            Console.Write("Por favor, insira a o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a altura do cilindo: ");
            double altura = double.Parse(Console.ReadLine());


            double volume = Math.PI * raio * raio * altura;

            Console.WriteLine("\nO volume da cilindro é de: " + volume);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nObrigado por usar nosso programa!");
            Console.ResetColor(); ;

            Console.ReadKey();
        }
    }
}

