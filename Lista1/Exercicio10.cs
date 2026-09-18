using System;
class Exercicio10 {
    static int[] Ocorrencias(int[] vetor){
        int[] ocorrencias = new int[6];
        for(int i = 0; i < vetor.Length; i++) {
            switch(vetor[i]) {
                case 1:
                    ocorrencias[0]++;
                    break;
                case 2:
                    ocorrencias[1]++;
                    break;
                case 3:
                    ocorrencias[2]++;
                    break;
                case 4:
                    ocorrencias[3]++;
                    break;
                case 5:
                    ocorrencias[4]++;
                    break;
                case 6:
                    ocorrencias[5]++;
                    break;

            }
        }
        return ocorrencias;
    }
    static void Main() {
        int n;
        Console.WriteLine("Digite o numero de lançamentos do dado: ");
        n = int.Parse(Console.ReadLine());
        int[] dado = new int[n];
        for(int i = 0; i < dado.Length; i++) {
            Console.Write($"Lancamento {i + 1}: ");
            dado[i] = int.Parse(Console.ReadLine());
        }
        int[] resultado = Ocorrencias(dado);
            Console.WriteLine("\nOcorrencias dos lançamentos:\n");
        for(int i = 0; i < resultado.Length; i++) {
            Console.WriteLine($"Lado {i+1}: {resultado[i]} ");
        }
    }
}