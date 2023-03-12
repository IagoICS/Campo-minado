using System;

namespace campoMinado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j,x, QTbombas1, QTbombas2, cont, escolhido = 1, escolhido2 = 1;
            string valortexto;
            int[,] tabuleiro = new int[11, 11];

            // Sortear as bombas e suas posições

            Random random = new Random();
            for (x = 0; x < 10; x++)
            {
                QTbombas1 = random.Next(1, 11);
                QTbombas2 = random.Next(1, 11);
                tabuleiro[QTbombas1, QTbombas2] = 32;
            }
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    if (tabuleiro[i, j] != 32)
                    {
                        cont = 0;
                        if (j <= 10 & j >= 1)
                        {
                            if (tabuleiro[i, j + 1] == 32)
                            {
                                cont = cont + 1;
                            }
                        }
                        if (j <= 10 & j >= 1)
                        {
                            if (tabuleiro[i, j - 1] == 32)
                            {
                                cont = cont + 1;
                            }
                        }
                        if (i <= 10 & i >= 1)
                        {
                            if (tabuleiro[i - 1, j] == 32)
                            {
                                cont = cont + 1;
                            }
                        }
                        if (i <= 10 & i >= 1)
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
            while (escolhido != 0 || escolhido2 != 0)
            {
                Console.Write("Digite um número de 1 até 10 para LINHA ou digite 0 para Sair: ");
                valortexto = Console.ReadLine();
                escolhido = int.Parse(valortexto);

                Console.Write("Digite um número de 1 até 10 para COLUNA ou digite 0 para Sair: ");
                valortexto = Console.ReadLine();
                escolhido2 = int.Parse(valortexto);

                if (((escolhido >= 0) & (escolhido <= 10)) & ((escolhido2 >= 0) & (escolhido2 <= 10)))
                {
                    i = escolhido;
                    if (((escolhido >= 0) & (escolhido <= 10)) & ((escolhido2 >= 0) & (escolhido2 <= 10)))
                    {
                        j = escolhido2;
                        if (tabuleiro[i, j] == 0)
                        {
                            Console.WriteLine("Espaço livre");
                        }
                        if ((tabuleiro[i, j] >= 1) & (tabuleiro[i, j] <= 4))
                        {
                            Console.WriteLine("Bombas por perto");
                        }
                        if (tabuleiro[i, j] >= 32)
                        {
                            Console.WriteLine("Você explodiu");
                            escolhido = 0;
                            escolhido2 = 0;
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}