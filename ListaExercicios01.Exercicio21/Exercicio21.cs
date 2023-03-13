//21.Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.
using System;

namespace ListaExercicios01.Exercicio21
{
    internal class Exercicio21
    {
        static void Main(string[] args)
        {
            int A, B, resultado;

            Console.Write("Digite o valor A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                resultado = A + B;
            }
            else
            {
                resultado = A * B;
            }

            Console.WriteLine("Resultado: " + resultado);
        }
    }
}

