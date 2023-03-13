//7. Crie um programa para calcular o salário total de um vendedor.
//Deverá ser informado o salário base e o total de vendas.
//A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioDeUmVendedor
{
    internal class Exercicio07
    {
        static void Main(string[] args)
        {
            //variaveis
            double salarioBase;
            double totalDeVendas;
            double percentualComissao;
            double salarioTotal;

            //entrada de dados: 
            Console.Write("\t\tInforme o salario base: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("\t\tInforme o total de vendas: ");
            totalDeVendas = double.Parse(Console.ReadLine());

            Console.Write("\t\tInforme o percentual da comissão: ");
            percentualComissao = double.Parse(Console.ReadLine());

            //calculo
            percentualComissao = totalDeVendas * (percentualComissao / 100.0);

            salarioTotal = salarioBase + percentualComissao;

            //saída de dados
            Console.Write("\t\tO salário total é de: " + salarioTotal);
        }
    }
}
