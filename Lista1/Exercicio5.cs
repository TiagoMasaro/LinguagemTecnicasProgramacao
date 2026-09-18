using System;
using BibliotecaFuncoes;
class Exercicio5 {
    static void AcharNumero(int[] vetor, int x) {
        bool flag = false;
        for(int i = 0; i < vetor.Length; i++) {
            if(vetor[i] == x) {
                Console.WriteLine($"Numero encontrado na posicão: {i}");
                flag = true;
            }
        }if(flag == false)
                Console.WriteLine("\nNUMERO NÃO ENCONTRADO!!!");
    }
    static void Main() {
        int n, x;
        Console.WriteLine();
        Console.Write("Quantos numeros seram sorteados: ");
        n = int.Parse((Console.ReadLine()));
        int [] vetor = new int[n];
        Biblioteca.gerarVetor(vetor);
        Console.Write("Digite um numero: ");
        x = int.Parse((Console.ReadLine()));
        AcharNumero(vetor, x);
        Console.WriteLine();
        Biblioteca.mostrarVetor(vetor);
    }
}