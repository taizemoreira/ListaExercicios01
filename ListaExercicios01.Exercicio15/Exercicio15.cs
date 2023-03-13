//15. Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler
//uma temperatura Celsius e imprima em Fahrenheit (pesquise como fazer este tipo de conversão).

namespace ListaExercicios01.Exercicio15
{
    public class Exercicio15
    {
        public static void Main(string[] args)
        {
            //Entrada de dados --> informar temperatura em celcius
            Console.Write("Informe a temperatura em Celsius: ");
            double temperaturaCelcius = Convert.ToDouble(Console.ReadLine());

            // Calculo --> conversão Fahrenheit
            double temperaturaFahrenheit = (temperaturaCelcius * 1.8) + 32;

            // Apresentar resultados na tela:
            Console.WriteLine("A temperatura em Fahrenheit é: " + temperaturaFahrenheit.ToString("F1"));
        }
    }
}
