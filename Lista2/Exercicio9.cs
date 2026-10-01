using System;
using BibliotecaMatriz;

class Exercicio9
{
    static void ExibirTropas(int[,] tropas)
    {
        for (int regiao = 0; regiao < tropas.GetLength(0); regiao++)
        {
            Console.Write($"Região {regiao + 1}: ");

            for (int cidade = 0; cidade < tropas.GetLength(1); cidade++)
            {
                Console.Write($"{tropas[regiao, cidade],3} ");
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("\nQuantidade de regiões(linhas): ");
        int qtdRegioes = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de cidades cidades(colunas): ");
        int qtdCidades = int.Parse(Console.ReadLine());

        int[,] tropas = new int[qtdRegioes, qtdCidades];

        Matriz.gerarMatriz(tropas);

        Console.WriteLine();
        Console.WriteLine("Matriz das Tropas (Quantidade de tropas pos cidade):");
        ExibirTropas(tropas);

        Console.WriteLine("\nForça Total das Regiões:");

        for (int regiao = 0; regiao < qtdRegioes; regiao++)
        {
            int total = 0;

            for (int cidade = 0; cidade < qtdCidades; cidade++)
            {
                total += tropas[regiao, cidade];
            }

            Console.WriteLine($"Região {regiao + 1}: {total}");
        }

        Console.ReadKey();
    }

}