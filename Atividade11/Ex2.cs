using System;

public class Ex2
{
    public static int[,] GerarMatriz(int linhas, int colunas, int min = 0, int max = 100)
    {
        int[,] matriz = new int[linhas, colunas];
        Random rnd = new Random();

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matriz[i, j] = rnd.Next(min, max + 1);
            }
        }

        return matriz;
    }

    public static void ExibirMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(5));
            }
            Console.WriteLine();
        }
    }

    public static int MaiorValor(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int maior = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }

        return maior;
    }

    public static int MenorValor(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int menor = matriz[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }

        return menor;
    }

    public static void Main(string[] args)
    {
        Console.Write("Digite o número de linhas (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas (M): ");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = GerarMatriz(n, m, 0, 100);

        Console.WriteLine("\nMatriz gerada:");
        ExibirMatriz(matriz);

        Console.WriteLine($"\nMaior valor: {MaiorValor(matriz)}");
        Console.WriteLine($"Menor valor: {MenorValor(matriz)}");
    }
}