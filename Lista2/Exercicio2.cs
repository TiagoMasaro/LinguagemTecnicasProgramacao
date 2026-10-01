using System;
using BibliotecaMatriz;

class Exercicio2
{
    static int EncontrarMenor(int[,] matriz)
    {
        int menorValor = matriz[0, 0];

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                int valorAtual = matriz[linha, coluna];

                if (valorAtual < menorValor)
                {
                    menorValor = valorAtual;
                }
            }
        }

        return menorValor;
    }

    static void Main()
    {
        Console.Write("\nDigite o numero de linhas: ");
        int qtdLinhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero de colunas: ");
        int qtdColunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[qtdLinhas, qtdColunas];

        Matriz.gerarMatriz(matriz);

        Console.WriteLine();
        Matriz.mostrarMatriz(matriz);

        int resultado = EncontrarMenor(matriz);

        Console.WriteLine($"\nMenor valor da Matriz: {resultado}");

        Console.ReadKey();
    }
}