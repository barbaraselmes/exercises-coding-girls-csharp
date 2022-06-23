namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] jokenpo = { "pedra", "papel", "tesoura" };
            int pontuacaoUsuario = 0;
            int pontuacaoComputador = 0;
            string campeao;
            int jogo;

            Console.WriteLine("VOCÊ FOI CONVOCADO PARA UMA PARTIDA DE JOKENPÔ! BORA?");

            do
            {
                Console.WriteLine("\nDigite o número de rodadas de Jokenpô que você quer jogar:");
                int rodadas = Convert.ToInt16(Console.ReadLine());

                for (int i = 0; i < rodadas; i++)
                {
                    Console.WriteLine("\nEscolha sua jogada:\nDigite \"1\" para pedra\nDigite \"2\" para papel\nDigite \"3\" para tesoura");
                    int jogadaDoUsuario = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine($"\nSua jogada: {jokenpo[jogadaDoUsuario - 1]}");

                    Random aleatorio = new Random();
                    int jogadaDoComputador = aleatorio.Next(0, 3);
                    Console.WriteLine($"Jogada do Computador: {jokenpo[jogadaDoComputador]}!");

                    switch (jogadaDoUsuario)
                    {
                        case 1:
                            if (jogadaDoComputador == 2)
                            {
                                pontuacaoUsuario++;
                                Console.WriteLine("Pedra vence tesoura. Arrasou! Você ganhou essa rodada!");
                            }
                            else if (jogadaDoComputador == 1)
                            {
                                pontuacaoComputador++;
                                Console.WriteLine("Pedra perde para papel. Que pena! Você perdeu essa rodada!");
                            }
                            else
                            {
                                Console.WriteLine("Eita, deu empate!");
                            }
                            break;
                        case 2:
                            if (jogadaDoComputador == 0)
                            {
                                pontuacaoUsuario++;
                                Console.WriteLine("Papel vence pedra. Boa! Você ganhou essa rodada!");
                            }
                            else if (jogadaDoComputador == 2)
                            {
                                pontuacaoComputador++;
                                Console.WriteLine("Papel perde para tesoura. Você perdeu essa rodada!");
                            }
                            else
                            {
                                Console.WriteLine("Empate!");
                            }
                            break;
                        case 3:
                            if (jogadaDoComputador == 0)
                            {
                                pontuacaoComputador++;
                                Console.WriteLine("Tesoura perde para pedra. Poxa! Você perdeu essa rodada!");
                            }
                            else if (jogadaDoComputador == 1)
                            {
                                pontuacaoUsuario++;
                                Console.WriteLine("Tesoura vence papel. Mandou bem! Você ganhou essa rodada!");
                            }
                            else
                            {
                                Console.WriteLine("Ta preula, deu empate!");
                            }
                            break;
                    }
                }

                Console.Write($"\n--- Você ganhou {pontuacaoUsuario} rodada(s) e ");
                Console.WriteLine($"a máquina ganhou {pontuacaoComputador} rodada(s)! ---");

                if (pontuacaoUsuario != pontuacaoComputador)
                {
                    campeao = (pontuacaoUsuario > pontuacaoComputador) ? "VOCÊ! PARABÉNS!" : "A MÁQUINA!";
                    Console.WriteLine($"------- PORTANTO, QUEM GANHOU A PARTIDA FOI {campeao} -------");
                }
                else
                {
                    Console.WriteLine($"------- PORTANTO, DEU EMPATE! -------");
                }


                Console.WriteLine($"\nVamos jogar novamente?\nDigite \"1\" para jogar novamente ou \"2\" para sair.");
                jogo = Convert.ToInt16(Console.ReadLine());

            } while (jogo == 1);

        }
    }
}