using System;

class Ex9
{
    static void Main()
    {
        Random rnd = new Random();

        Console.Write("Digite o número de regiões (R): ");
        int R = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o número de cidades por região (C): ");
        int C = int.Parse(Console.ReadLine()!);

        int[,] matrizTropas = new int[R, C];

        // 1. Preenchimento com valores aleatórios (0 a 100)
        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                matrizTropas[i, j] = rnd.Next(0, 101);
            }
        }

        // 2. Exibição da matriz
        Console.WriteLine("\nMatriz das Tropas (Quantidade de Tropas por Cidade):");
        for (int i = 0; i < R; i++)
        {
            Console.Write($"Região {i + 1}: ");
            for (int j = 0; j < C; j++)
            {
                Console.Write($"{matrizTropas[i, j]} ");
            }
            Console.WriteLine();
        }

        // 3. Soma total das tropas por região (linha)
        Console.WriteLine("\nForça Total das Regiões:");
        for (int i = 0; i < R; i++)
        {
            int somaRegiao = 0; // zerado a cada nova região

            for (int j = 0; j < C; j++)
            {
                somaRegiao += matrizTropas[i, j];
            }

            Console.WriteLine($"Região {i + 1}: {somaRegiao} tropas");
        }
    }
}