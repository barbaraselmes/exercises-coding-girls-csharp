using System;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EXERCÍCIO 01: VALOR MONETÁRIO ---");
            Exercicio01();
            Console.WriteLine("\n--- EXERCÍCIO 02: MAIOR VALOR ---");
            Exercicio02();
            Console.WriteLine("\n--- EXERCÍCIO 03: APROVAÇÃO DE ALUNO ---");
            Exercicio03();
            Console.WriteLine("\n--- EXERCÍCIO 04: NOTA DE ALUNO ---");
            Exercicio04();
            Console.WriteLine("\n--- EXERCÍCIO 05: AUMENTO DE SALÁRIO ---");
            Exercicio05();
        }

        static void Exercicio01()
        {
            int[] notas = { 100, 50, 20, 10, 5, 2 };
            int[] quantidade = { 0, 0, 0, 0, 0, 0 };
            int i = 0;

            Console.WriteLine("Digite um valor monetário.");
            float valorMonetario = float.Parse(Console.ReadLine());

            foreach (int n in notas)
            {
                while (valorMonetario >= n)
                {
                    quantidade[i] += 1;
                    valorMonetario -= n;
                }
                Console.WriteLine($"{quantidade[i]} nota(s) de R$ {notas[i]}.00");
                i++;
            }

            if (valorMonetario > 0)
            {
                double moedas = Math.Round(valorMonetario, 2);
                Console.WriteLine($"e {moedas:0.00} em moedas");
            }

            Console.WriteLine("\nAperte qualquer tecla para visualizar o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio02()
        {
            float maior;

            Console.WriteLine("Digite o primeiro valor numérico: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor numérico: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor numérico: ");
            float valor3 = float.Parse(Console.ReadLine());

            maior = (valor1 > valor2 && valor1 > valor3) ? valor1 : valor2;

            if (valor3 > valor1 && valor3 > valor2)
            {
                maior = valor3;
            }

            Console.WriteLine($"O maior valor é o {maior}!");

            Console.WriteLine("Aperte qualquer tecla para visualizar o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio03()
        {
            float media;
            string situacao;

            Console.WriteLine("Digite a primeira nota do aluno: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
            
            situacao = (media >= 7) ? "aprovado" : "reprovado";

            Console.WriteLine($"Aluno {situacao} com média {media:0.0}.");

            Console.WriteLine("Aperte qualquer tecla para visualizar o próximo exercício...");
            Console.ReadKey();

        }

        static void Exercicio04()
        {
            float soma = 0;
            float media;
            float[] notas = new float[3];
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine($"Digite a {i+1}ª nota do aluno:");
                notas[i] = Convert.ToSingle(Console.ReadLine());
                i++;
            }

            foreach (int n in notas)
            {
                soma += n;
            }

            media = soma / 3;

            if (media >= 0 && media < 6.0)
            {
                Console.WriteLine($"A média do aluno foi {media:0.00}, nota: “F”.");
            }

            else if (media >= 6.0 && media < 7.0)
            {
                Console.WriteLine($"A média do aluno foi {media:0.00}, nota: “D”.");
            }

            else if (media >= 7.0 && media < 8.0)
            {
                Console.WriteLine($"A média do aluno foi {media:0.00}, nota: “C”.");
            }

            else if (media >= 8.0 && media < 9.0)
            {
                Console.WriteLine($"A média do aluno foi {media:0.00}, nota: “B”.");
            }

            else if (media >= 9.0 && media <= 10.0)
            {
                Console.WriteLine($"Muito bom! A média do aluno foi {media:0.00}, nota: “A”.");
            }

            else
            {
                Console.WriteLine($"Média inválida!\nVocê digitou valores fora do intervalo [0, 10] para as notas.");
            }

            Console.WriteLine("Aperte qualquer tecla para visualizar o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio05()
        {
            float[] p = { 0.15f, 0.12f, 0.10f , 0.07f, 0.04f };
            int i;
            float reajuste;
            float reajustep;
            float salarioNovo;
            Console.WriteLine($"Digite o salário atual do funcionário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.Write($"O salário atual de R${salario:0.00}");

            i = (salario <= 400.00) ? 0 : 1;

            if (salario > 800.00 && salario <= 1200.00)
            {
                i = 2;
            }

            else if (salario > 1200.00 && salario <= 2000.00)
            {
                i = 3;
            }

            else if (salario > 2000.00)
            {
                i = 4;
            }

            reajuste = Calculo(p[i], salario, out reajustep, out salarioNovo);

            Console.WriteLine($" sofrerá um reajuste de {reajustep}%, que corresponde à R${reajuste:0.00} a mais.");
            Console.WriteLine($"Sendo assim, o novo salário será R${salarioNovo:0.00}.");

            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey();
        }

        static float Calculo(float i, float salario, out float reajustep, out float salarioNovo)
        {
            float reajuste = salario * i;
            reajustep = 100 * i;
            salarioNovo = salario * (1 + i);
            return reajuste;
        }
        }
}
