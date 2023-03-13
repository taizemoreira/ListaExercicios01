//10. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios01.Exercicio10
{
    internal class Exercicio10
    {
        static void Main(string[] args)
        {
            // Definição das variáveis
            double prova1, prova2;
            double peso1, peso2;
            double mediaPonderada;

            // Entrada de dados
            Console.WriteLine("Digite a nota da primeira prova: ");
            prova1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira prova: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            prova2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso da segunda prova: ");
            peso2 = double.Parse(Console.ReadLine());

            // Calcular a média ponderada
            mediaPonderada = ((prova1 * peso1) + (prova2 * peso2) / (peso1 * peso2));

            // Exibir o resultado para o usuário
            Console.WriteLine("A média ponderada das duas provas é: " + mediaPonderada);

        }
        
    }
}
