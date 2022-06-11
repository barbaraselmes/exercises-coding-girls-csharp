using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01___Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- EXERCÍCIO 01: DADOS PESSOAIS ---");
            Exercicio01();
            Console.WriteLine("\n--- EXERCÍCIO 02: MULHERES NA TECNOLOGIA ---");
            Exercicio02();
            Console.WriteLine("\n--- EXERCÍCIO 03: MÚSICA ---");
            Exercicio03();
            Console.WriteLine("\n--- EXERCÍCIO 04: FRASE ---");
            Exercicio04();
        }

        static void Exercicio01()
        {
            Console.WriteLine("Digite o seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu endereço:");
            string endereço = Console.ReadLine();

            Console.WriteLine("Digite o seu CEP (apenas números):");
            string cep = Console.ReadLine();
            string cepFormato = cep.Insert(5, "-");

            Console.WriteLine("Digite o seu telefone com DDD (apenas números):");
            string telefone = Console.ReadLine();
            string telefoneFormato = telefone.Insert(0, "(").Insert(3, ") ").Insert(10, "-");

            Console.WriteLine($"\nNome: {nome}\nEndereço: {endereço}\nCEP: {cepFormato}\nTelefone: {telefoneFormato}");
            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio02()
        {
            string nome = "Grace Brewster Murray Hopper";
            string formacao = "PhD em matemática";
            string contribuicaoTech = "Grace foi uma importante pioneira da área de linguagens da computação. " +
               "\nUma de suas grandes contribuições para a área, foi a criação do primeiro compilador, chamado A-0, e a construção da linguagem COBOL!";

            Console.WriteLine($"Nome: {nome}\nFormação: {formacao}\nContribuição: {contribuicaoTech}");
            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio03()
        {
            int i = 0;

            Console.WriteLine("Crazy Little Thing Called Love" +
                "\n\nThis thing called love, " + "I  just can't handle it"
                + "\nThis thing called love, " + "I must get round to it"
                + "\nI ain't ready"
                + "\nCrazy little thing called love"
                + "\n(...)\n");

            Console.WriteLine("I gotta be cool, relax, get hip!" +
                "\nGet on my track's, " + "take a back seat" +
                "\nHitchhike" +
                "\nAnd take a long ride on my motor bike " + "until I'm ready" +
                "\nCrazy little thing called love"
                + "\n(...)\n");

            while (i <= 6)
            {
                Console.WriteLine("Crazy little thing called love, yeah, yeah");
                i++;
            }

            Console.WriteLine("\nCompositor: Freddie Mercury" + "\nGênero: Rockabilly");
            Console.WriteLine("\nAperte qualquer tecla para ver o próximo exercício...");
            Console.ReadKey();
        }

        static void Exercicio04()
        {
            Console.WriteLine("Se hoje temos programação e wi-fi a culpa é das mulheres! Este lugar também é seu, entre no time e vamos juntas fazer parte dessa culpa!");
            Console.WriteLine("\nAperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
