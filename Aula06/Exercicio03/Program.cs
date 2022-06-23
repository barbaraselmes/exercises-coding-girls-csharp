//Aula 06: Orientação a Objetos
//Exercicio 03: Fatura de Serviço

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- LOJA DE SUPRIMENTOS DE INFORMÁTICA -----");
            Console.WriteLine("Digite o número da fatura: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição do produto: ");
            string descricaoDosProdutos = Console.ReadLine();

            Console.WriteLine("Digite a quantidade comprada:");
            int quantidadeComprada = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            Fatura fatura1 = new Fatura(numero, descricaoDosProdutos, quantidadeComprada, preco);
        }

    }
}
