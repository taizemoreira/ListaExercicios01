// Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
using System;

namespace EscreverNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Gera e escreve os números ímpares entre 100 e 200";
            int larguraTela = Console.WindowWidth;
            int larguraTexto = texto.Length;
            int espacos = (larguraTela / 2) + (larguraTexto / 2);
            Console.WriteLine(texto.PadLeft(espacos));

            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 101; i <= 199; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

