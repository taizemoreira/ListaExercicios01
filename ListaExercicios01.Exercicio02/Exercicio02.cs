//2. Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios01.Exercicio02
{
    internal class Exercicio02
    {
        static void Main(string[] args)
        {
            // Declaração de Variáveis
            double F;
            double C;

            //Solicita e lê a informação da temperatura na escala 
            Console.Write("\t\tPor favor informe a temperatura na escala Fahrenheit: ");
            F = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            // Efetua a conversão de temperatura       
            C = (F - 32) * 5 / 9;

            // Exibe o resultado da Conversão de temperatura
            Console.WriteLine($"\t\tA temperatura na escala Celsius é: {C} ");
            Console.WriteLine();               
        }
    }
}
