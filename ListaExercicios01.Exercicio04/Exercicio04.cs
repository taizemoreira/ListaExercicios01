//4. Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
////Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoConsumoCombustivel
{
    class Exercicio04
    {
        static void Main(string[] args)
        {
            //declaração de variáveis
            double quilometragemInicial;
            double quilometragemFinal;
            double litrosConsumidos;
            double distanciaPercorrida;

            //solicitando dados ao usuario
            Console.WriteLine("Qual a quilometragem inicial?");
            quilometragemInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quilometragem final?");
            quilometragemFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos litros de combustível foram gastos?");
            litrosConsumidos = double.Parse(Console.ReadLine());

            // calculando quilometragem total
            double quilometragemTotal = quilometragemFinal - quilometragemInicial;

            //calculando o consumo de combustivel
            double consumoDeCombustivel = quilometragemInicial / quilometragemFinal;

            Console.WriteLine("A quilometragem Inicial é de : " + quilometragemInicial + " litros por quilômetro");
            
            Console.WriteLine("A quilometragem Final é de : " + quilometragemFinal + " litros por quilômetro");

            Console.WriteLine("O consumo de combustível por quilômetro percorrido é de : " + consumoDeCombustivel + " litros por quilômetro");
        }
    }
}
