//Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
using System;

namespace VerificarParOuImpar
{ 
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Verificar Par Ou Impar";
            int larguraTela = Console.WindowWidth;
            int larguraTexto = texto.Length;
            int espacos = (larguraTela / 2) + (larguraTexto / 2);
            Console.WriteLine(texto.PadLeft(espacos));

            Console.Write("Informe um número inteiro qualquer: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", numero);
            }

            Console.ReadLine();
        }
    }
}


