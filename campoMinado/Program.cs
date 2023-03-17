using System;

namespace campoMinado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j, x, QTbombas1, QTbombas2, cont, escolhido = 1, escolhido2 = 1;
            string valortexto;
            int[,] tabuleiro = new int[11, 11];

            // Sortear as bombas e suas posições

            Random random = new Random();
            for (x = 0; x < 10; x++)
            {
                QTbombas1 = random.Next(1, 9);
                QTbombas2 = random.Next(1, 9);

                tabuleiro[QTbombas1, QTbombas2] = 32;
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (tabuleiro[i, j] != 32)
                    {
                        cont = 0;
                        if (j < 9)
                        {
                            if (tabuleiro[i, j + 1] == 32)
                            {
                                cont = cont + 1;
                            }
                        }
                        if (j > 1)
                        {
                            if (tabuleiro[i, j - 1] == 32)
                            {
                                cont = cont + 1;
                            }
                        }
                        if (i > 1)
                        {
                            if (tabuleiro[i - 1, j] == 32)
                            {
                                cont = cont + 1;
                            }
                        }
                        if (i > 9)
                        {
                            if (tabuleiro[i + 1, j] == 32)
                            {
                                cont = cont + 1;

                            }
                        }
                        tabuleiro[i, j] = cont;

                    }
                }
            }

            while ((escolhido != 0) || (escolhido2 != 0))
            {
                Console.WriteLine("1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10 - ");
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 10; j++)
                    {
                        if ((tabuleiro[i, j] == 0) || ((tabuleiro[i, j] > 0) & (tabuleiro[i, j] <= 4)) || (tabuleiro[i, j] == 32))
                        {
                            Console.Write("X" + " | ");
                        }
                        else if (tabuleiro[i, j] == 72)
                        {
                            Console.Write(" " + " | ");
                        }
                        else if (tabuleiro[i, j] == 91)
                        {
                            Console.Write("1" + " | ");
                        }
                        else if (tabuleiro[i, j] == 92)
                        {
                            Console.Write("2" + " | ");
                        }
                        else if (tabuleiro[i, j] == 93)
                        {
                            Console.Write("3" + " | ");
                        }
                        else if (tabuleiro[i, j] == 94)
                        {
                            Console.Write("4" + " | ");
                        }
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("1 - 2 - 3 - 4 - 5 - 6 - 7 - 8 - 9 - 10 - ");
                Console.Write("Digite um número de 1 até 10 para LINHA ou digite 0 para Sair: ");
                valortexto = Console.ReadLine();
                escolhido = int.Parse(valortexto);

                Console.Write("Digite um número de 1 até 10 para COLUNA ou digite 0 para Sair: ");
                valortexto = Console.ReadLine();
                escolhido2 = int.Parse(valortexto);

                if (((escolhido > 0) & (escolhido <= 10)) & ((escolhido2 > 0) & (escolhido2 <= 10)))
                {
                    i = escolhido - 1;
                    if (((escolhido > 0) & (escolhido <= 10)) & ((escolhido2 > 0) & (escolhido2 <= 10)))
                    {
                        j = escolhido2 - 1;
                        if (tabuleiro[i, j] == 0)
                        {
                            Console.WriteLine("Espaço livre");
                            tabuleiro[i, j] = 72;

                            for (i = 0; i < 10; i++)
                            {
                                for (j = 0; j < 10; j++)
                                {
                                        cont = 0;
                                        if (j < 9)
                                        {
                                            if (tabuleiro[i, j + 1] == 0)
                                            {
                                                tabuleiro[i, j + 1] = 72;
                                            }
                                        }
                                        if (j > 1)
                                        {
                                            if (tabuleiro[i, j - 1] == 0)
                                            {
                                                tabuleiro[i, j - 1] = 72;
                                        }
                                        }
                                        if (i > 1)
                                        {
                                            if (tabuleiro[i - 1, j] == 0)
                                            {
                                                tabuleiro[i - 1, j ] = 72;
                                        }
                                        }
                                        if (i < 9)
                                        {
                                            if (tabuleiro[i + 1, j] == 0)
                                            {
                                                tabuleiro[i + 1, j] = 72;
                                            }
                                        }
                                }
                            }
                        }
                        if ((tabuleiro[i, j] >= 1) & (tabuleiro[i, j] <= 4))
                        {
                            Console.WriteLine("Bombas por perto");
                            if (tabuleiro[i, j] == 1)
                            {
                                tabuleiro[i, j] = 91;
                            }
                            if (tabuleiro[i, j] == 2)
                            {
                                tabuleiro[i, j] = 92;
                            }
                            if (tabuleiro[i, j] == 3)
                            {
                                tabuleiro[i, j] = 93;
                            }
                            if (tabuleiro[i, j] == 4)
                            {
                                tabuleiro[i, j] = 94;
                            }
                        }
                        if (tabuleiro[i, j] == 32)
                        {
                            Console.WriteLine("Você explodiu");
                            escolhido = 0;
                            escolhido2 = 0;

                            for (i = 0; i < 10; i++)
                            {
                                for (j = 0; j < 10; j++)
                                {
                                    Console.Write(tabuleiro[i, j] + " | ");
                                }
                                Console.Write("\n");
                            }
                            Console.WriteLine("0 = Espaços livres, 1 ate 4 = quantidade de bombas ao redor, 32 = bombas, 72 = bomba que você explodiu");
                            Console.ReadKey();

                        }
                    }
                }
            }
        }
    }
}
