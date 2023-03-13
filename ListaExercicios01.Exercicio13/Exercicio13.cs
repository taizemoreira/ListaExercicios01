//13.A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia.
//Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50.
//Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
//Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
//quantidades de pães e de broas, e depois calcular os dados solicitados.
namespace ListaExercicios01.Exercicio13
{
    public class AlgoritmoDaPadaria
    {
        public static void Main(string[] args)
        {

            int qtdePaes, qtdeBroas;
            double valorPoupanca;
            double totalVendas;

            Console.WriteLine("Informe a quantidade de pães vendidos no dia");
            qtdePaes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de broas vendidas no dia:");
            qtdeBroas = Convert.ToInt32(Console.ReadLine());

            //calculo arrecadação && poupaça
            totalVendas = (qtdePaes * 0.12) + (qtdeBroas * 1.50);
            valorPoupanca = totalVendas * 0.1;

            //apresentação dos resultados na tela
            Console.WriteLine("O total das vendas foi de R$ " + totalVendas.ToString("F2"));
            Console.WriteLine("O valor para a poupança é R$ " + valorPoupanca.ToString("F2"));
        }
    }
}

