using System;
using System.IO;

class ExercicioMatriz
{
    // Lê o CSV e devolve a matriz 6x6
    static int[,] carregarMatriz(string caminho)
    {
        int[,] matriz = new int[6, 6];
        string[] linhas = File.ReadAllLines(caminho);   // uma string por linha

        for (int i = 0; i < 6; i++)
        {
            string[] valores = linhas[i].Split(',');    // separa pelas vírgulas
            for (int j = 0; j < 6; j++)
                matriz[i, j] = int.Parse(valores[j].Trim());  // texto -> inteiro
        }
        return matriz;
    }

    // Mostra a matriz na tela
    static void exibirMatriz(string titulo, int[,] matriz)
    {
        Console.WriteLine(titulo);
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
                Console.Write(matriz[i, j] + " ");
            Console.WriteLine();   // pula linha ao fim de cada linha da matriz
        }
        Console.WriteLine();
    }

    // Retorna o percentual de cada código: [0] desmatada, [1] parcial, [2] preservada
    static double[] calcularPercentuaDesmatamento(int[,] matriz)
    {
        double[] cont = new double[3];   // contadores do tipo double

        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 6; j++)
                cont[matriz[i, j]]++;    // o valor da célula é o índice do contador

        for (int k = 0; k < 3; k++)
            cont[k] = cont[k] / 36 * 100;   // vira percentual do total de 36 células

        return cont;
    }

    // Compara os dois períodos e mostra o relatório
    static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
    {
        double ant = calcularPercentuaDesmatamento(matrizAnterior)[0];
        double atu = calcularPercentuaDesmatamento(matrizAtual)[0];

        Console.WriteLine("Percentual de ocorrências na matriz 6 meses atrás:");
        Console.WriteLine("Área Desmatada (Código 0): {0:F2}%", ant);
        Console.WriteLine("Percentual de ocorrências na matriz atual:");
        Console.WriteLine("Área Desmatada (Código 0): {0:F2}%", atu);

        if (atu > ant)
            Console.WriteLine("Houve Aumento no Desmatamento – Anterior {0:F2}% -> Atual {1:F2}%", ant, atu);
        else if (atu < ant)
            Console.WriteLine("Houve Redução no Desmatamento – Anterior {0:F2}% -> Atual {1:F2}%", ant, atu);
        else
            Console.WriteLine("O Desmatamento permaneceu estável em {0:F2}%", atu);
    }

    static void Main()
    {
        int[,] anterior = carregarMatriz("dados_matriz_6meses_atras.csv");
        int[,] atual = carregarMatriz("dados_matriz_atual.csv");

        exibirMatriz("Matriz de 6 meses atrás:", anterior);
        exibirMatriz("Matriz atual:", atual);

        analisarAumento(anterior, atual);
    }
}