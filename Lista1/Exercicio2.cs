using System;
using BibliotecaFuncoes;

class Exercicio2 {
      static int ContarImpar(int[] vetor) {
        int contImpar = 0;
        for(int i = 0; i < vetor.Length; i++) {
            if(vetor[i] % 2 != 0) {
                contImpar++;
            }
        }
        return contImpar;
    }
    static void Main(){
        int n, contImpar;
        Console.Write("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int [] meuVetor = new int[n];
        Biblioteca.gerarVetor(meuVetor);
        Biblioteca.mostrarVetor(meuVetor);
        contImpar = ContarImpar(meuVetor);
        Console.Write($"quantidade de Impars no vetor: {contImpar}");
    }
}