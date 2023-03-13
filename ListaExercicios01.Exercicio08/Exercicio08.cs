//8. Crie um programa para calcular o volume de uma lata de óleo
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeDaLata
{ 
    public class Exercicio08
    {
        static void Main(string[] args)
        {
            //variaveis
            double pi = 13.14;
            double raio;                  
            double altura;
            double volumeLata;

            //entrada de dados do usuário
            Console.WriteLine("Informe o raio da lata: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora, Informe a altura da lata: ");
            altura = double.Parse(Console.ReadLine());
           
            //calculo
            //Fórmula: V = pi * r^2 * h
            volumeLata = pi * Math.Pow(raio,2) * altura;

            Console.WriteLine($"\nO volume da lata é: " + volumeLata);
        }
    }
}
