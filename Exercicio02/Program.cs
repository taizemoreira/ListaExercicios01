// Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
using System;

namespace ConverteParaCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem-vindo ao programa de conversão da temperatura!");
            Console.ResetColor();

            double fahrenheit;

            Console.Write("Por favor, insira a temperatura em Fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());   

            double celcius = (fahrenheit - 32) / 1.8;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ResetColor();
            Console.WriteLine("\nA temperatura em Celcius é de: " + celcius);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nObrigado por usar nosso programa!");
            Console.ResetColor();
           
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

            