// O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma
// indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ².
// Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
// Condição Abaixo de 18,5 --> Abaixo do peso
//  Entre 18,5 e 25 --> Peso normal
//  Entre 25 e 30  Acima do peso --> Acima de 30 obeso
using System;

namespace CalcularImc
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "CÁLCULO DO IMC";
            int larguraTela = Console.WindowWidth;
            int larguraTexto = texto.Length;
            int espacos = (larguraTela / 2) + (larguraTexto / 2);
            Console.WriteLine(texto.PadLeft(espacos));

            // Leitura dos valores 
            Console.Write("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double valorImc = peso / (altura * altura);

            if (valorImc < 18.5)
            {
                Console.Write("Abaixo do peso ");
            }
            if (valorImc >= 18.5 && valorImc < 25)
            {
                Console.Write("Peso normal ");
            }
            if (valorImc > 25 && valorImc < 30)
            {
                Console.Write("Acima do peso ");
            }
            if (valorImc > 30)
            {
                Console.Write("Obeso ");
            }
        }
    }
}


