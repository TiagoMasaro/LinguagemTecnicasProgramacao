using System;
using BibliotecaMatriz;

class Exercicio5
{
    static int ContarOcorrencias(int[,] matriz, int numero)
    {
        int quantidade = 0;

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                if (matriz[linha, coluna] == numero)
                {
                    quantidade++;
                }
            }
        }

        return quantidade;
    }

    static void Main()
    {
        Console.Write("\nNumero de Linhas: ");
        int qtdLinhas = int.Parse(Console.ReadLine());

        Console.Write("Numero de Colunas: ");
        int qtdColunas = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero para verificar: ");
        int numeroProcurado = int.Parse(Console.ReadLine());

        int[,] matriz = new int[qtdLinhas, qtdColunas];

        Matriz.gerarMatriz(matriz);

        Console.WriteLine("\nMatriz Gerada!");
        Matriz.mostrarMatriz(matriz);

        int quantidade = ContarOcorrencias(matriz, numeroProcurado);

        if (quantidade != 0)
        {
            Console.WriteLine($"\nO numero {numeroProcurado} aparece {quantidade} vezes na matriz!!");
        }
        else
        {
            Console.WriteLine($"\nO numero {numeroProcurado} nao aparece na matriz!");
        }

        Console.ReadKey();
    }

}