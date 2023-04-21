// Crie um programa para calcular o consumo de combustível por Km.
// Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo.
// Deverá ser informado o Consumo de Combustível
using System;

namespace CalculoConsumoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************************************************\n");
            Console.WriteLine("  Cálculo de consumo de combustível por Km!\n");
            Console.WriteLine("************************************************\n");
            Console.ResetColor();

            //A fórmula para calcular o volume de um cilindro é: V = π * r ^ 2 * h


            Console.Write("Por favor, informe a quilometragem Inicial: ");
            double quilometragemInicial = double.Parse(Console.ReadLine());

            Console.Write("Agora, informe a quilometragem Final: ");
            double quilometragemFinal = double.Parse(Console.ReadLine());

            Console.Write("Agora, informe a quantidade de combustivel consumida: ");
            double qtdeCombustivelconsumida = double.Parse(Console.ReadLine());

            double consumoPorKm = (quilometragemFinal - quilometragemInicial) / qtdeCombustivelconsumida;


            Console.WriteLine("\n Consumo de combustível por Km: " + consumoPorKm);

            Console.ReadKey();
        }
    }
}

