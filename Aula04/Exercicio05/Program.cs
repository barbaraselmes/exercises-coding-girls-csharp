namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //matriz do tabuleiro (3x3)
            string[,] tabuleiro = new string[3, 3];
            int posicao = 0;
            string jogador, jogador1, jogador2;
            string marcacao, jogada;
            string error = "tudoOK";

            Console.WriteLine("------------------ PARTE 1: DEFINIR MARCAÇÃO ------------------\nDefina a marcação que o jogador \"Número 1\" irá utilizar:");
            Console.WriteLine("Digite \"1\" para ser o círculo (O) ou digite \"2\" para ser o xis (X)");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                jogador1 = "O";
                jogador2 = "X";
            }
            else
            {
                jogador1 = "X";
                jogador2 = "O";
            }

            Console.Clear();
            Console.WriteLine("------------------- MARCAÇÃO DEFINIDA --------------------\n");
            Console.WriteLine($"O jogador \"Número 1\" será o ({jogador1}) e o jogador \"Número 2\" será o ({jogador2})!\n\n");

            Console.WriteLine("------------------ PARTE 2: BORA JOGAR! -------------------\n");

            //preencher e imprimir na tela a matriz (tabuleiro) com números de 1 a 9
            for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
                {
                    posicao++;
                    tabuleiro[linha, coluna] = Convert.ToString(posicao);
                    Console.Write($"|        {tabuleiro[linha, coluna]}         ");
                }
                Console.Write("|");
                Console.WriteLine("\n----------------------------------------------------------");
            }

            for (int deQuemEAVez = 1; deQuemEAVez <= tabuleiro.Length; deQuemEAVez++)
            {
                if (deQuemEAVez % 2 != 0)
                {
                    marcacao = jogador1;
                    jogador = "Jogador Número 1";
                }
                else
                {
                    marcacao = jogador2;
                    jogador = "Jogador Número 2";
                }

                Console.WriteLine($"\n{jogador}, digite o número da posição da sua jogada: \n*Atenção: A posição deverá contemplar um número entre 1 e 9!");
                int jogada1 = int.Parse(Console.ReadLine());

                jogada = (jogada1 == 1 && tabuleiro[0, 0] != jogador1 && tabuleiro[0, 0] != jogador2) ? tabuleiro[0, 0] = marcacao :
                         (jogada1 == 2 && tabuleiro[0, 1] != jogador1 && tabuleiro[0, 1] != jogador2) ? tabuleiro[0, 1] = marcacao :
                         (jogada1 == 3 && tabuleiro[0, 2] != jogador1 && tabuleiro[0, 2] != jogador2) ? tabuleiro[0, 2] = marcacao :
                         (jogada1 == 4 && tabuleiro[1, 0] != jogador1 && tabuleiro[1, 0] != jogador2) ? tabuleiro[1, 0] = marcacao :
                         (jogada1 == 5 && tabuleiro[1, 1] != jogador1 && tabuleiro[1, 1] != jogador2) ? tabuleiro[1, 1] = marcacao :
                         (jogada1 == 6 && tabuleiro[1, 2] != jogador1 && tabuleiro[1, 2] != jogador2) ? tabuleiro[1, 2] = marcacao :
                         (jogada1 == 7 && tabuleiro[2, 0] != jogador1 && tabuleiro[2, 0] != jogador2) ? tabuleiro[2, 0] = marcacao :
                         (jogada1 == 8 && tabuleiro[2, 1] != jogador1 && tabuleiro[2, 1] != jogador2) ? tabuleiro[2, 1] = marcacao :
                         (jogada1 == 9 && tabuleiro[2, 2] != jogador1 && tabuleiro[2, 2] != jogador2) ? tabuleiro[2, 2] = marcacao : error = "error";

                Console.Clear();
                if (error == "error")
                {
                    Console.WriteLine("Você jogou em uma posição já preenchida ou fora do intervalo [1,9]. Jogue novamente!\n");
                    deQuemEAVez -= 1;
                    error = "tudoOK";
                }

                Console.WriteLine("------------------ PARTIDA EM ANDAMENTO -------------------\n");

                for (int linha = 0; linha < tabuleiro.GetLength(0); linha++)
                {
                    for (int coluna = 0; coluna < tabuleiro.GetLength(1); coluna++)
                    {
                        Console.Write($"|        {tabuleiro[linha, coluna]}         ");
                    }
                    Console.Write("|");
                    Console.WriteLine("\n----------------------------------------------------------");
                }

                if ((tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 0] == tabuleiro[0, 2]) ||
                    (tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 0] == tabuleiro[1, 2]) ||
                    (tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 0] == tabuleiro[2, 2]) ||
                    (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[0, 0] == tabuleiro[2, 0]) ||
                    (tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[0, 1] == tabuleiro[2, 1]) ||
                    (tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[0, 2] == tabuleiro[2, 2]) ||
                    (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2]) ||
                    (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[0, 2] == tabuleiro[2, 0]))
                {
                    Console.WriteLine("\n----------------------- FIM DE JOGO -----------------------");
                    Console.WriteLine($"\n({marcacao}) GANHOU! Parabéns {jogador}, mandou bem!");
                    break;
                }
                else if (deQuemEAVez == tabuleiro.Length)
                {
                    Console.WriteLine("\n----------------------- FIM DE JOGO -----------------------");
                    Console.WriteLine("\nDeu velha!");
                }
            }
        }
    }
}
