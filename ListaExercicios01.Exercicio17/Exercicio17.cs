//17. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
namespace ListaExercicios01.Exercicio17
{
    public class Exercicio17
    {
        public static void Main(string[] args)
        {
            //Entrada de dados do usuario
            Console.WriteLine("Insira o valor A: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira o valor C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            //if verificador
            if (A + B < C)
            {
                Console.WriteLine("A soma de A + B é menor que C ");
            }
            else
            {
                Console.WriteLine("A soma de A + B é maior ou igual a C");
            }
        }
    }
}
