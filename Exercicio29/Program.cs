// Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10.
// Para isso, o programa deve gerar todas as combinações de multiplicação entre 1 e 10, exibindo o resultado de cada operação na tela.
//a.Desafio: Para cada número, tente separar em colunas.
using System;

namespace ExibirTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define o tamanho das colunas da tabuada
            const int columnWidth = 5;

            // Exibição da tabuada de multiplicação do 1 ao 10
            for (int i = 1; i <= 10; i++)
            {
                // Imprime o número da tabuada
                Console.Write($"{i,2} |");

                // Imprime a linha horizontal
                Console.Write(new string('-', columnWidth * 10));

                // Pula uma linha para a próxima tabuada
                Console.WriteLine();

                // Imprime a coluna de resultados
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,columnWidth} ");
                }

                // Pula uma linha para a próxima tabuada
                Console.WriteLine();
            }
        }
    }
}
