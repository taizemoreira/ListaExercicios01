//Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
//encontram no conjunto dos números de 1 até 500.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios01.Exercicio24
{
    internal class Exercicio24
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("Soma de todos os números ímpares: " + soma);
        }
    }
}
