using System;
using BibliotecaMatriz;

class Exercicio11
{
    static int SomaPrincipal(int[,] matriz)
    {
        int total = 0;
        int tamanho = matriz.GetLength(0);

        for (int posicao = 0; posicao < tamanho; posicao++)
        {
            total += matriz[posicao, posicao];
        }

        return total;
    }

    static int SomaSecundaria(int[,] matriz)
    {
        int total = 0;
        int tamanho = matriz.GetLength(0);

        for (int posicao = 0; posicao < tamanho; posicao++)
        {
            int coluna = tamanho - 1 - posicao;
            total += matriz[posicao, coluna];
        }

        return total;
    }

    static void Main()
    {
        Console.Write("\nNumero de linhas: ");
        int qtdLinhas = int.Parse(Console.ReadLine());

        Console.Write("numero de colunas: ");
        int qtdColunas = int.Parse(Console.ReadLine());

        int[,] mapaTesouro = new int[qtdLinhas, qtdColunas];

        Matriz.gerarMatriz(mapaTesouro);

        Console.WriteLine("\nMapa do tesouro(Quantidade de moedas por região:)");
        Matriz.mostrarMatriz(mapaTesouro);

        int valorPrincipal = SomaPrincipal(mapaTesouro);
        int valorSecundario = SomaSecundaria(mapaTesouro);

        Console.WriteLine();
        Console.WriteLine($"Soma da diagonal Principal: {valorPrincipal}");
        Console.WriteLine($"Soma da diagonal secundaria: {valorSecundario}");

        Console.WriteLine();

        if (valorPrincipal > valorSecundario)
        {
            Console.WriteLine("O maior tesouro esta na diagonal principal, Vamos para lá!!");
        }
        else
        {
            Console.WriteLine("O maior tesouro esta na diagonal secundaria, Vamos para lá!!");
        }

        Console.ReadKey();
    }

}