namespace Exercicio01
{
    public class AlunosMatriculados
    {

        public int Matricula;
        public string Nome = "";
        public double Nota1;
        public double Nota2;
        public double NotaDoTrabalho;

        public double CalcularMedia()
        {
            double media;
            Console.WriteLine("Digite a nota da primeira prova: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota do Trabalho: ");
            NotaDoTrabalho = Convert.ToDouble(Console.ReadLine());

            media = (Nota1 + Nota2 + NotaDoTrabalho) / 3;
            Console.WriteLine($"\nCom base nas notas, a média final do aluno foi {media:0.00}");

            return media;
        }

        public void CalcularNotaFinal()
        {
            double media = CalcularMedia();

            Console.WriteLine();

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado!\nPor ter uma média maior ou igual a 7 (sete) o aluno passou direto e não precisará fazer a prova final.");
            }
            else
            {
                double notaFinalNecessaria;
                notaFinalNecessaria = 10 - media;
                Console.WriteLine("Infelizmente, por ter uma média menor do que 7 (sete) o aluno precisará realizar a prova final.");
                Console.WriteLine($"Para ser aprovado, o aluno precisará tirar {notaFinalNecessaria:0.00} na prova final, e assim, ficar com média maior ou igual a 5.");
            }
        }
    }
}
