// Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
// Considere sempre anos completos, e que um ano possui 365 dias.
// Ex: uma pessoa com 19 anos possui 6935 dias de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
using System;

namespace LerNomeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            // Cálculo
            int totalDiasVividos = idade * 365;
           
            Console.WriteLine(nome +", você já viveu:" + totalDiasVividos + " dias.");
        }
    }
}
