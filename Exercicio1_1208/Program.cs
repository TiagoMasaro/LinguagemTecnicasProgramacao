using System;

class Program
{
    // ler o vetor
    static void lerVetor(int[] vetor)
    {
        Console.WriteLine("[Função] Entre com os dados do vetor: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Array[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        } // fim do for
    }

    static void mostrarVetor(int[] vetor)
    {
        Console.WriteLine("[Função] Dados do vetor: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("|" + vetor[i]);
        }
        Console.WriteLine("|");
    }

    // uma função que RECEBE o vetor como parâmetro
    // e RETORNA a soma de seus elementos
    static int somarVetor(int[] vetor)
    {
        int soma = 0; // acumular o total
        for (int i = 0; i < vetor.Length; i++)
        {
            soma = soma + vetor[i]; // vai somando cada elemento do vetor
        }
        return soma; // devolve o resultado 
    }

    static void Main()
    {
        Console.Write("Digite o valor de N (tamanho do vetor): ");
        int n = int.Parse(Console.ReadLine());

        int[] meuArray = new int[n];
        lerVetor(meuArray);
        mostrarVetor(meuArray);
        int resultado = somarVetor(meuArray);

        Console.WriteLine($"A soma dos elementos do vetor é: {resultado}");
    }
}