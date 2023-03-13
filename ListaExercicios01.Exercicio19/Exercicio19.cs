//19.O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
// IMC em adultos Condição
// Abaixo de 18,5
// Abaixo do peso
// Entre 18,5 e 25 Peso normal
// Entre 25 e 30
// Acima do peso
// Acima de 30 obeso

namespace ListaExercicios01.Exercicio19
{
    internal class Exercicio19
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Informe o peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("IMC: Abaixo do peso", imc);
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("IMC: Peso normal", imc);
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("IMC: Acima do peso", imc);
            }
            else
            {
                Console.WriteLine("IMC: Obeso", imc);
            }
        }
    }
}

