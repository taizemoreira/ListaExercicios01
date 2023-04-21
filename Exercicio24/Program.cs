// Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram
// no conjunto dos números de 1 até 500.
using System;

namespace SomaDosNumerosImpares
{
    class Program
    {        
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("A soma dos números ímpares que são múltiplos de três entre 1 e 500 é: {0}", soma);

            Console.ReadLine();
        }
    }
}


