using System;
using BibliotecaFuncoes;
class Exercicio7 {
    static int AcharNumero(int[] vetor, int x) {
        int contador = 0;
        for(int i = 0; i < vetor.Length; i++) {
            if(vetor[i] == x)
                contador++;
        }
        return contador;

    }
    static void Main() {
        int n, x;
        Console.Write("Tamanho do Vetor: ");
        n = int.Parse(Console.ReadLine());
        int[] vetor = new int[n];
        Console.WriteLine();
        Biblioteca.gerarVetor(vetor);
        Console.WriteLine("\nQual valor quer achar: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDados do vetor: ");
        Biblioteca.mostrarVetor(vetor);
        int cont = AcharNumero(vetor, x);
        Console.WriteLine($"\nO numero {x} aparece {cont} vez no vetor!\n");
    }
}