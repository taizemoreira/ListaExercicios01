//11. Crie um programa para verificar se um número é primo.
namespace ListaExercicios01.Exercicio11
{
    internal class Exercicio11
    {
        static void Main(string[] args)
        {       
            int numero;
            int numeroInteiro;
            int i = 0;

            Console.WriteLine("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            bool primo = true;

            //comando for para verificação
            for (numeroInteiro = 2; i < numero; i++)
            {
                if (numero % 1 == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            if (primo == true && numero > 1)
            {
                Console.WriteLine(numero + " é um número primo.");
            }
            else
            {
                Console.WriteLine(numero + " não é um número primo.");
            }
   
        }
    }
}
