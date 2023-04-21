// Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
using System;

namespace CalculoMediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cálculo da média ponderada do aluno\n\n");
            Console.ResetColor();

            // pede para o usuário digitar as notas
            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da primeira nota: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da segunda nota: ");
            double peso2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da terceira nota: ");
            double peso3 = double.Parse(Console.ReadLine());


            // calcula a média ponderada
            double mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2);

            // imprime o resultado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A média ponderada é {mediaPonderada:N2}");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}


