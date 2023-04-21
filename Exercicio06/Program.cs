// Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
using System;

namespace ConverterTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de conversão da temperatura!\n");

            Console.Write("Por favor, insira a temperatura em Celcius: ");
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = (celcius * 1.8) + 32;

            Console.WriteLine("\nTemperatura em graus Fahrenheit: " + fahrenheit);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

