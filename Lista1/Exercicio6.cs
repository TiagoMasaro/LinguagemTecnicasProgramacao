using System;
using BibliotecaFuncoes;
class Exercicio6{
    static int[] MultiplicarVetor(int[] vetorA, int[] vetorB) {
        int[] soma = new int[vetorA.Length];
        for(int i = 0; i < vetorA.Length; i++) 
            soma[i] = vetorA[i] * vetorB[i];
        return soma;
    }
    static void Main(){
        int n;
        Console.Write("Tamanho dos vetores: ");
        n = int.Parse(Console.ReadLine());
        int[] vetorA = new int[n];
        int[] vetorB = new int[n];
        int[] vetorC = new int[n];

        Biblioteca.gerarVetor(vetorA);
        Biblioteca.gerarVetor(vetorB);
        
        vetorC = MultiplicarVetor(vetorA, vetorB);
        Console.WriteLine("\nDados da multiplicação: vetorA x vetorB");
        Biblioteca.mostrarVetor(vetorC);

    }
}