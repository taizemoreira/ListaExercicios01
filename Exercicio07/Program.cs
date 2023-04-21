// Crie um programa para calcular o salário total de um vendedor.
// Deverá ser informado o salário base e o total de vendas.
// A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
using System;

namespace CalculoSalarioVendedor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Bem-vindo à Calculadora Top de Salário! ");
            Console.WriteLine("-------------------------------------- ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("              $$$$$$  ");
            Console.WriteLine("             $$    $$  ");
            Console.WriteLine("            $$        ");
            Console.WriteLine("             $$$$$$    ");
            Console.WriteLine("                  $$   ");
            Console.WriteLine("            $$    $$   ");
            Console.WriteLine("             $$$$$$    ");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Por favor, informe o total de vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Por favor, informe o valor do salário base: ");
            double salarioBaseVendedor = double.Parse(Console.ReadLine());

            Console.Write("Por favor, informe o percentual de comissão atribuido às suas vendas: ");
            double percentualComissao = double.Parse(Console.ReadLine());
            
            double salarioTotalVendedor = salarioBaseVendedor + (percentualComissao / 100) * totalVendas; ;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nO salário total do vendedor é: " + salarioTotalVendedor + "Reais");
            Console.ResetColor();

            Console.WriteLine("\nObrigado por usar nosso programa!");
   
            Console.ReadKey();
        }
    }
}

