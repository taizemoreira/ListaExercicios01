// Crie um programa para calcular a média harmônica das notas de um Aluno
using System;

namespace CalculoMediaHarmonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cálculo da média harmônica do aluno\n\n   ");
            Console.ResetColor();

            // pede para o usuário digitar as notas
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            double nota4 = double.Parse(Console.ReadLine());

            Console.Write("Digite a quinta nota: ");
            double nota5 = double.Parse(Console.ReadLine());

            // calcula a média harmônica
            double mediaHarmonica = 5 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4) + (1 / nota5));

            // imprime o resultado

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A média harmônica é {mediaHarmonica:N2}");
            Console.ResetColor();
       
            Console.ReadKey();
        }
    }
}

