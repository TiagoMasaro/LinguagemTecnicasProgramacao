using System;
using BibliotecaMatriz;

class Exercicio7
{
    static int[,] CalcularSoma(int[,] primeira, int[,] segunda)
    {
        int totalLinhas = primeira.GetLength(0);
        int totalColunas = primeira.GetLength(1);

        int[,] resultado = new int[totalLinhas, totalColunas];

        for (int linha = 0; linha < totalLinhas; linha++)
        {
            for (int coluna = 0; coluna < totalColunas; coluna++)
            {
                resultado[linha, coluna] =
                    primeira[linha, coluna] + segunda[linha, coluna];
            }
        }

        return resultado;
    }

    static void Main()
    {
        int linhas;
        int colunas;

        do
        {
            Console.Write("Numero de Linhas: ");
            linhas = int.Parse(Console.ReadLine());

            Console.Write("Numero de Colunas: ");
            colunas = int.Parse(Console.ReadLine());

            if (linhas != colunas)
            {
                Console.WriteLine("\nEntre com valores validos(linhas == colunas)\n");
            }

        } while (linhas != colunas);

        int[,] matrizA = new int[linhas, colunas];
        int[,] matrizB = new int[linhas, colunas];

        Matriz.gerarMatriz(matrizA);
        Matriz.gerarMatriz(matrizB);

        Console.WriteLine("\nMatriz A:");
        Matriz.mostrarMatriz(matrizA);

        Console.WriteLine("\nMatriz B:");
        Matriz.mostrarMatriz(matrizB);

        int[,] resultado = CalcularSoma(matrizA, matrizB);

        Console.WriteLine("\nSoma Das Matrizes:");
        Matriz.mostrarMatriz(resultado);
    }

}