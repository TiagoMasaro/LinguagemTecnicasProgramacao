using System;
using BibliotecaFuncoes;
class Exercicio1 {
    static int SomarVetor(int[] vetor) {
        int soma = 0;
        for(int i = 0; i < vetor.Length; i++) {
            soma += vetor[i];
        }
        return soma;
    }
    static void Main() {
        int n, resultadoSoma;
        Console.WriteLine("Qual o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Biblioteca.mostrarVetor(vetor);
        resultadoSoma = SomarVetor(vetor);
        Console.WriteLine($"Soma dos elementos do vetor: {resultadoSoma}");
        
    }
    
}
