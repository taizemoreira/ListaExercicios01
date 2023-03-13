//14.Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
//Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
//de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

namespace CalcularTempoDeVida
{
    public class CalcularTempoDeVida
    {
        public static void Main(string[] args)
        {
            // Entrada de dados:
            Console.Write("Informe seu nome completo: ");
            string nomePessoa = Console.ReadLine();

            Console.Write("Informe sua idade: ");
            int idadePessoa = Convert.ToInt32(Console.ReadLine());

            // Calcullo dos dias de vida da pessoa
            int diasDeVida = idadePessoa * 365;

            // Exibir a mensagem para o usuário
            Console.WriteLine(nomePessoa.ToUpper() + ", VOCÊ JÁ VIVEU " + diasDeVida + " DIAS.");
        }
    }
}

    

