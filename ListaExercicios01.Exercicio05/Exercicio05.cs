// 5. Crie um programa para calcular o volume de uma esfera
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaVolumeEsfera
{
    class Exercicio05
    {
        public static void Main(string[] args)
        {
            //variaveis
            double raio;
            double volumeEsfera;
            double pi = 3.14;

            Console.WriteLine("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            //calculo
            // V= 4/3*pi*r^3

            volumeEsfera = (4 / 3) * pi * Math.Pow(raio, 3);

            //Resultado
            Console.WriteLine($"\nO volume da esfera é: " + volumeEsfera);

        }
    }
}
