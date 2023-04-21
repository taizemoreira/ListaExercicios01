// Crie um programa para verificar se um número é primo.
using System;

namespace VerificarNumeroPrimo
{
    class Program

    {
        static void Main(string[] args)
        {
            int num, i, count = 0;

            //solicitar que o usuário digite um número inteiro positivo
            Console.Write("Digite um número inteiro positivo: ");
            num = int.Parse(Console.ReadLine());

            //loop for que irá testar se o número é divisível por cada número entre 1 e o próprio número
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    //Se o número for divisível por um determinado número, o contador count é incrementado em 1
                    count++;
                }
            }

            /* 
            Se o contador count for igual a 2(ou seja, o número é divisível apenas por 1 e por ele mesmo),
            o programa exibe a mensagem informando que o número é primo.
            Caso contrário,
            é exibida a mensagem informando que o número não é primo. 
            */
            if (count == 2)
            {
                Console.WriteLine(num + " é um número primo.");
            }
            else
            {
                Console.WriteLine(num + " não é um número primo.");
            }
        }
    }
}
    

