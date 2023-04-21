// Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
using System;

namespace ConverteParaCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de conversão da temperatura!\n");

            Console.Write("Por favor, insira a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celcius = (fahrenheit - 32) / 1.8;

            Console.WriteLine("\nA temperatura em Celcius é de: " + celcius);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

