//20. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
using System;
namespace ListaExercicios01.Exercicio20
{
    public class Exercicio20
    {
        static void Main(string[] args)
        {           
            int numeroQualquer;
            
            Console.WriteLine($"Digite o numero: ");
            numeroQualquer = int.Parse(Console.ReadLine());

            if (numeroQualquer % 2 == 0)
            {
                Console.WriteLine($"O número " + numeroQualquer + " é par");
            }
            else
            {
                Console.WriteLine($"O número " + numeroQualquer + " é ímpar");
            }
        }
    }
}
