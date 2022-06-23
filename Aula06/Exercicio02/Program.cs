//Aula 06: Orientação a Objetos
//Exercicio 02: Gerenciando Salários

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do(a) funcionário: ");
            string funcionario = Console.ReadLine();

            Console.WriteLine($"Digite o cargo de {funcionario}:");
            string cargo = Console.ReadLine();

            Console.WriteLine($"Digite o salário mensal de {funcionario}:");
            double salario = double.Parse(Console.ReadLine());

            Empregado empregado1 = new Empregado(funcionario, cargo, salario);
        }

    }
}
