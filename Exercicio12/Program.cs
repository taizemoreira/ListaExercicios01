// A imobiliária Imóbilis vende apenas terrenos retangulares.
// Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
using System;

namespace CalculoAreaTerreno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Leitura das dimensões do terreno
            Console.WriteLine("Digite a largura do terreno em metros:");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terreno em metros:");
            double comprimento = double.Parse(Console.ReadLine());

            // Cálculo da área do terreno
            double area = largura * comprimento;

            // Exibição da área do terreno
            Console.WriteLine($"A área do terreno é de {area} metros quadrados.");
        }
    }
}
