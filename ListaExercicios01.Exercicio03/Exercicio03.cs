//Crie um programa para calcular o volume de um Cilindro
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoVolumeCilindro
{
    class Exercicio03
    {
        static void Main(string[] args)
        {
            //entrada
            double raio;
            double altura;
            double volume;

            Console.Write("Informe o raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro é: " + volume.ToString("F2"));
        }
    }
}
