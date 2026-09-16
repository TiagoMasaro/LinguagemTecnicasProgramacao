using System;

class Program
{
    static int quantRaios(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > 1)
                {
                    return 1;
                }
            }
        }
        return 0;
    }

    static void Main()
    {
        int[,] mapa = new int[501, 501];

        int ocorrencias = 0;
        do
        {
            Console.WriteLine("Digite a quantidade de raios que caíram: ");
            ocorrencias = int.Parse(Console.ReadLine()!);
        } while (!(ocorrencias >= 2 && ocorrencias <= 500000));

        for (int i = 0; i < ocorrencias; i++)
        {
            int x = -1;
            int y = -1;
            do
            {
                Console.WriteLine($"Raio {i + 1}:");
                x = int.Parse(Console.ReadLine()!);
                y = int.Parse(Console.ReadLine()!);
            }
            while (!(x >= 0 && x <= 500 && y >= 0 && y <= 500));
            mapa[x, y]++;
        }
        Console.WriteLine("Foi encontrado uma incidência! ");
        Console.WriteLine($"{quantRaios(mapa)}");
    }
}