namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[5];

            for (int i = 0; i < palavras.Length; i++)
            {
                Console.WriteLine($"Digite a {i + 1}ª palavra.");
                palavras[i] = Console.ReadLine();
            }

            IEnumerable<string> palavrasOrdenadas = from palavra in palavras
                                                    orderby palavra.Length
                                                    select palavra;

            Console.WriteLine("vetor: [" + String.Join(", ", palavrasOrdenadas) + "]");

            Console.ReadKey();
        }
    }
}