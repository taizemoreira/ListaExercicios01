// Entrada, Processamento e Saída de Dados
//Crie um programa para calcular o volume de uma caixa retangular
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios01.Exercicio01
{
    class Exercicio01
    {
        public static void Main(string[] args)
        {
            int volumeCaixa;
            int largura;
            int comprimento;
            int altura;

            Console.WriteLine("Informe a largura da caixa: ");
            largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Agora, Informe o comprimento da caixa: ");
            comprimento = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe também a altura da caixa: ");
            altura = Convert.ToInt32(Console.ReadLine());

            volumeCaixa = largura * altura *comprimento;

            Console.WriteLine($"\nO volume da caixa é: " + volumeCaixa);
         
        }
    }
}
