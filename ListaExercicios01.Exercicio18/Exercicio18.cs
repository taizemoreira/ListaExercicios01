//18. Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
using System;

namespace ListaExercicios01.Exercicio18
{
    internal class Exercicio18
    {
        public static void Main(string[] args)
        {
            //Entrada de dados do usuario
            Console.WriteLine("Insira o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            // utilizando if
            if (valor1 > valor2)
            {
                int cont = valor1;
                valor1 = valor2;
                valor2 = cont;
            }
            if (valor2 > valor3)
            {
                int cont = valor2;
                valor2 = valor3;
                valor3 = cont;
            }
            if (valor1 > valor2)
            {
                int cont = valor1;
                valor1 = valor2;
                valor2 = cont;
            }

            
            Console.WriteLine(valor3 + " " + valor2 + " " + valor1);
        }
    }
}
