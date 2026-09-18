using System;
using BibliotecaFuncoes;
 class Exercicio3 {
    
    static double MaiorNumero(double[] vetor) {
        double maior = vetor[0];
        for(int i = 0; i < vetor.Length; i++) {
            if(maior < vetor[i])
                maior = vetor[i];
        }
        return maior;
    }
    static void Main() {
        int n;
        double maior;
        Console.WriteLine("Qual o tamanho do vetor: ");
        n = int.Parse(Console.ReadLine());
        double [] vetor = new double[n];
        Biblioteca.GerarVetorDouble(vetor);
        Biblioteca.MostrarVetorDouble(vetor);
        maior = MaiorNumero(vetor);
        Console.WriteLine($"Maior valor do vetor: {maior:f2}.");


    }
}

