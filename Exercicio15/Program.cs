// Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit.
// Faça um algoritmo para ler uma temperatura Celsius e imprima em Fahrenheit (pesquise como fazer este tipo de conversão).
using System;

namespace ConverteParaFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa de conversão da temperatura!\n");

            Console.Write("Por favor, insira a temperatura em celcius: ");
            double celcius = double.Parse(Console.ReadLine());

            //°F = (°C × 1.8) + 32
            double fahrenheit = (celcius * 1.8 ) + 32;

            Console.WriteLine("\nA temperatura em Fahrenheit é de: " + fahrenheit);

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}