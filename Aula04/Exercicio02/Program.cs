namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int qtdPares = 0;
            int qtdImpares = 0;
            int j = 0;
            int k = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número.");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    qtdPares++;
                }
                else
                {
                    qtdImpares++;
                }
            }


            int[] numerosPares = new int[qtdPares];
            int[] numerosImpares = new int[qtdImpares];

            foreach (int n in vetor) {
                if (n % 2 == 0)
                {
                    numerosPares[j] = n;
                    j++;
                }
                else
                {
                    numerosImpares[k] = n;
                    k++;
                }
            }

            Console.WriteLine("vetor de números pares: [" + String.Join(", ", numerosPares) + "]");

            Console.WriteLine("vetor de números ímpares: [" + String.Join(", ", numerosImpares) + "]");

            Console.ReadKey();
        }
    }
}
