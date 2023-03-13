//12.A imobiliária Imóbilis vende apenas terrenos retangulares.
//Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios01.Exercicio12
{
    internal class Exercicio12
    {
        static void Main(string[] args)
        {
            //Variáveis
            double larguraTerreno, comprimentoTerreno, areaTerreno;

            //Entrada dos dados
            Console.WriteLine("Informe a largura do terreno: ");
            larguraTerreno = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento do terreno: ");
            comprimentoTerreno = double.Parse(Console.ReadLine());

            //calculo da area
            areaTerreno = larguraTerreno * comprimentoTerreno;

            //Apresentando o resultado na tela:
            Console.WriteLine("A área do terreno é de: "+ areaTerreno + " metros quadrados");
        }
    }
}