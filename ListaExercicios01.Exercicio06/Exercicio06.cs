//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusParaFahrenheit;

internal class Exercicio06
{
    static void Main(string[] args)
    {
        // Declaração de Variáveis
        double F;
        double C;

        //Solicita e lê a informação da temperatura na escala 
        Console.Write("\t\tPor favor informe a temperatura na escala Celcius: ");
        C = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        // Efetua a conversão de temperatura       
        F = ((C * 1.8) + 32);

        // Exibe o resultado da Conversão de temperatura
        Console.WriteLine($"\t\tA temperatura na escala Fahrenheit é: {F} ");
        Console.WriteLine();
    }
}
  
    


