using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EXERCÍCIO 01: IDADE ---");
            Exercicio01();
            Console.WriteLine("\n--- EXERCÍCIO 02: SOMA DE INTEIROS ---");
            Exercicio02();
            Console.WriteLine("\n--- EXERCÍCIO 03: CÁLCULO DE SALÁRIO ---");
            Exercicio03();
            Console.WriteLine("\n--- EXERCÍCIO 04: IDADE EM ANOS/MESES/DIAS ---");
            Exercicio04();
            Console.WriteLine("\n--- EXERCÍCIO 05: CONVERSOR DE MOEDAS ---");
            Exercicio05();
        }

        static void Exercicio01()
        {
            int anoAtual = DateTime.Today.Year;

            Console.WriteLine("Qual o seu ano de nascimento?");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idade = anoAtual - anoNascimento;

            Console.WriteLine($"\nVocê tem {idade} anos!");

            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio02()
        {
            int num1;
            int num;
            int soma = 0;

            List<int> numeros = new List<int>();

            Console.WriteLine("Digite o primeiro valor do tipo inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            numeros.Add(num1);

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Boa! Agora digite outro valor do tipo inteiro: ");
                num = int.Parse(Console.ReadLine());
                numeros.Add(num);
            }

            foreach (int n in numeros)
            {
                soma += n;
            }

            Console.WriteLine($"\nA soma dos dez valores digitados é {soma}!");

            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio03()
        {
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor recebido por hora: ");
            float valorHora = float.Parse(Console.ReadLine());

            float salario = horasTrabalhadas * valorHora;

            Console.WriteLine($"\nO salário é de R${salario:00.00}.");

            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio04()
        {
            int meses;
            int dias;

            Console.WriteLine("Digite a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            dias = idade * 365;

            Console.WriteLine($"Você tem {idade} anos.\nA sua idade em meses é: {meses}.");
            Console.WriteLine($"A sua idade dias é: {dias}.");

            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio05()
        {
            Console.OutputEncoding = Encoding.UTF8;
            decimal dolar = 4.9m;
            decimal euro = 5.25m;
            decimal libraEsterlina = 6.14m;
            decimal dolarCanadense = 3.90m;
            decimal pesoArgentino = 0.04m;
            decimal pesoChileno = 0.006m;

            Console.WriteLine("Digite um valor em real (R$): ");
            decimal real = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\n--- conversões ---\n");

            Console.WriteLine($"O valor R${real} é equivalente ao valor ${decimal.Round(real / dolar, 2)} (dólar);");
            Console.WriteLine($"O valor R${real} é equivalente ao valor €{decimal.Round(real / euro, 2)} (euro);");
            Console.WriteLine($"O valor R${real} é equivalente ao valor £{decimal.Round(real / libraEsterlina, 2)} (libra esterlina);");
            Console.WriteLine($"O valor R${real} é equivalente ao valor ${decimal.Round(real / dolarCanadense, 2)} (dólar canadense);");
            Console.WriteLine($"O valor R${real} é equivalente ao valor ${decimal.Round(real / pesoArgentino, 2)} (peso argentino);");
            Console.WriteLine($"O valor R${real} é equivalente ao valor ${decimal.Round(real / pesoChileno, 2)} (peso chileno).");

            Console.WriteLine("\nAperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
