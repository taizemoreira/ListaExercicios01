//16.Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
//Após o aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.

namespace ListaExercicios01.Exercicio16
{
    internal class Exercicio16
    {
        public static void Main(string[] args)
        {
            //solicitação da entrada de dados
            Console.WriteLine("Informe o salário do funcionário: ");
            double salarioInicial = double.Parse(Console.ReadLine());

            //calculo com aumento de salário do funcionario
            double SalarioComAumento = salarioInicial * 1.15;

            //descontando 8% de impostos
            double salarioFinal = SalarioComAumento * 0.92;

            //exibindo resultados na tela
            Console.WriteLine("Salário inicial: R$ " + salarioInicial.ToString("F2"));
            Console.WriteLine("Salário com o aumento: R$ " + SalarioComAumento.ToString("F2"));
            Console.WriteLine("Salário final após descontar impostos: R$ " + salarioFinal.ToString("F2"));

        }
    }
}
