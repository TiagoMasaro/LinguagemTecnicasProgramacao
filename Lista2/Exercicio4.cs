using System;
using BibliotecaMatriz;

class Exercicio4
{
    static void Main()
    {
        Console.Write("\nNumero de Linhas: ");
        int qtdLinhas = int.Parse(Console.ReadLine());

        Console.Write("Numeros de Colunas: ");
        int qtdColunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[qtdLinhas, qtdColunas];

        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.WriteLine("\nDiagonal Secundaria:");

        for (int linha = 0; linha < qtdLinhas; linha++)
        {
            for (int coluna = 0; coluna < qtdColunas; coluna++)
            {
                int posicao = qtdColunas - 1 - linha;

                if (coluna == posicao)
                {
                    Console.Write($"{matriz[linha, coluna],3}");
                }
                else
                {
                    Console.Write("   ");
                }
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }

}