using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    var peca = tab.peca(i, j);

                    if (peca == null)
                    {
                        Console.Write("- ");

                    }
                    else
                    {
                        Console.Write(peca + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
