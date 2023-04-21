// A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.
// Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.
// Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos),
// e quanto deve guardar numa conta de poupança (10% do total arrecadado).
// Você foi contratado para fazer os cálculos para o dono.
// Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de broas, e depois calcular os dados solicitados.
using System;

namespace LerCalcularDadosPadaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+------------------------+");
            Console.WriteLine("|     Padaria Hotpão     |");
            Console.WriteLine("+------------------------+");
            Console.ResetColor();
            Console.WriteLine();

            double PrecoPaozinho = 0.12;
            double PrecoBroa = 1.50; 

            Console.WriteLine("Informe o valor total da venda dos pães:");
            double totalVendaPaozinho = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade dos pães vendidas:");
            double quantidadePaozinhosVendidos = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total da venda das broas:");
            double totalVendaBroas = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe a quantidade das broas vendidas:");
            double quantidadeBroasVendidas = double.Parse(Console.ReadLine());

            double TotalVendasFinalDia = totalVendaPaozinho + totalVendaBroas;        

            // Cálculo da porcentagem
            double totalVendasFinalDia = (quantidadePaozinhosVendidos * totalVendaPaozinho) + (quantidadeBroasVendidas * totalVendaBroas);
            double valorPoupanca = totalVendasFinalDia/10;

            Console.WriteLine("O valor total arrecadado foi de R$" + totalVendasFinalDia.ToString("F2")); //função que formata um número com duas casas decimais.
            Console.WriteLine("O valor a ser guardado na poupança é de R$" + valorPoupanca.ToString("F2"));
        }
    }
}
