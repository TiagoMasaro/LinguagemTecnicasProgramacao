using System;
using BibliotecaMatriz;

class Exercicio8
{
    static void Main()
    {
        const int TAMANHO = 501;

        int[,] registros = new int[TAMANHO, TAMANHO];

        Console.Write("\nQuantidade de raios registrados: ");
        int quantidade = int.Parse(Console.ReadLine());

        int encontrouRepetido = 0;

        for (int raio = 1; raio <= quantidade; raio++)
        {
            Console.Write($"Cordenadas do raio {raio}: ");

            string[] dados = Console.ReadLine().Split(" ");

            int linha = int.Parse(dados[0]);
            int coluna = int.Parse(dados[1]);

            registros[linha, coluna]++;

            if (registros[linha, coluna] > 1)
            {
                encontrouRepetido = 1;
            }
        }

        Console.WriteLine(encontrouRepetido);
    }

}