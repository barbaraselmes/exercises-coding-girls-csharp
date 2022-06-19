namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] vetor = new float[10];
            float[] vetorx5 = new float[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número.");
                vetor[i] = float.Parse(Console.ReadLine());
                vetorx5[i] = vetor[i] * 5;
            }

            Console.WriteLine("vetor: [" + String.Join(", ", vetor) + "]");

            Console.WriteLine("5 * vetor: [" + String.Join(", ", vetorx5) + "]");

            Console.ReadKey();
        }
    }
}

