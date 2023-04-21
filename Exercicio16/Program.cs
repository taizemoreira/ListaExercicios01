//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. 
//Após o aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.
using System;

namespace LerSalarioFuncionario
{
    class Program

    {
        static void Main(string[] args)
        {
            double salario, salarioAumento, salarioFinal;
            const double aumento = 0.15, imposto = 0.08;

            Console.WriteLine("============================");
            Console.WriteLine("   SALÁRIO DO FUNCIONÁRIO    ");
            Console.WriteLine("============================\n");

            Console.Write("Digite o salário do funcionário: R$ ");
            salario = double.Parse(Console.ReadLine());

            salarioAumento = salario * (1 + aumento);
            salarioFinal = salarioAumento * (1 - imposto);

            Console.WriteLine("\n-------------------------------------------------------------");
            Console.WriteLine("  RESUMO DO SALÁRIO");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"Salário inicial: R$ {salario:F2}");
            Console.WriteLine($"Salário com aumento (15%): R$ {salarioAumento:F2}");
            Console.WriteLine($"Salário final (com desconto de imposto): R$ {salarioFinal:F2}");
            Console.WriteLine("-------------------------------------------------------------\n");
        }
    }
}
