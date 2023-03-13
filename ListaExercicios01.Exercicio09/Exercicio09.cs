using System;
//9. Crie um programa para calcular a média harmônica das notas de um Aluno
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaHarmonica
{
    internal class Exercicio09
    {
        static void Main(string[] args)
        {
            //Entrada das notas 
            Console.WriteLine("Digite a primeira nota do aluno:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno:");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota do aluno:");
            double nota4 = double.Parse(Console.ReadLine());

            double notas = nota1 + nota2 + nota3 + nota4;

            //Calcular a média harmônica das notas
            double MediaHarmonica = 0;
            for (int i = 0; i < notas; i++)
            {
                MediaHarmonica += 1 / notas;
            }
            double mediaHarm = notas / MediaHarmonica;

            //Mostrar o resultado na tela
            Console.WriteLine("A média harmônica das notas do aluno é: " + MediaHarmonica);
        }
    }
}
