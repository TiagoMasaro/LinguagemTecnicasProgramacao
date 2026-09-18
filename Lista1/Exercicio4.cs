using System;
using BibliotecaFuncoes;
 class Exercicio4 {
    static double MenorNumero(double[] vetor) {
        double menor = vetor[0];
        for(int i = 0; i < vetor.Length; i++) {
            if(menor > vetor[i])
                menor = vetor[i];
        }
        return menor;
    }
    static void Main() {
        int n;
        double menor;
        Console.WriteLine("Qual o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        double [] vetor = new double[n];
        Biblioteca.GerarVetorDouble(vetor);
        Biblioteca.MostrarVetorDouble(vetor);
        menor = MenorNumero(vetor);
        Console.WriteLine($"Menor valor do vetor: {menor:f2}.");


    }
}

