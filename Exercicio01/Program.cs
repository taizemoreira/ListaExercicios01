// Crie um programa para calcular o volume de uma caixa retangular
using System;

namespace CalculoVolumeCaixa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem-vindo ao programa de cálculo de volume de caixa!");
            Console.ResetColor();

            Console.Write("Por favor, insira a largura da caixa em centímetros: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Agora, insira a altura da caixa em centímetros: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Por fim, insira a profundidade da caixa em centímetros: ");
            double profundidade = double.Parse(Console.ReadLine());

            double volume = largura * altura * profundidade;

            Console.WriteLine("\nO volume da caixa é de: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(volume);
            Console.ResetColor();
            Console.WriteLine(" centímetros cúbicos.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nObrigado por usar nosso programa!");
            Console.ResetColor();;

            Console.ReadKey();
        }
    }
}

