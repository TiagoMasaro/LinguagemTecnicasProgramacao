using System;
using BibliotecaMatriz;

class Exercicio1 {
    static int MaiorValor(int[,] matriz) {
        int linhas = matriz.GetLength(0); // recebe as linhas
        int colunas = matriz.GetLength(1); // recebe as colunas

        int maior = matriz[0, 0];
        for(int i = 0; i < linhas; i++) {
            for(int j = 0; j < colunas; j++) {
                
                if(matriz[i, j] > maior) // encontrar o maior valor dentro da matriz
                    maior = matriz[i, j];
            }
        } 
        return maior; 
    }
    static void Main() {
        int linhas, colunas;
        Console.Write("\nDigite o numero de linhas: ");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Digite o numero de colunas: ");
        colunas = int.Parse(Console.ReadLine());

       
        int[,] matriz = new int[linhas, colunas];
        Matriz.lerMatriz(matriz);
        Console.WriteLine();
        Matriz.mostrarMatriz(matriz);

        
        Console.WriteLine($"\nMaior valor da Matriz: {MaiorValor(matriz)}");
        Console.ReadKey();
    }
}