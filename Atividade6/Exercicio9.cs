using System;

class Exercicio9
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a fita de DNA: (lembrando que as fitas são compostas por A, C, T, G)");
        string fita = Console.ReadLine().ToUpper();

        char[] dnaArray = fita.ToCharArray();
        char[] complementar = new char[dnaArray.Length];

        for (int i = 0; i < dnaArray.Length; i++)
        { //comeco do for
            char dna = dnaArray[i];

            if (dna == 'A')
            {
                complementar[i] = 'T';
            }
            else if (dna == 'T')
            {
                complementar[i] = 'A';
            }
            else if (dna == 'C')
            {
                complementar[i] = 'G';
            }
            else if (dna == 'G')
            {
                complementar[i] = 'C';
            }
            else
            {
                Console.WriteLine("Base inválida encontrada: " + dna);
                return;
            }
        } //fim do for

        string fitaComplementar = new string(complementar);

        Console.WriteLine("Fita original: " + fita);
        Console.WriteLine("Fita complementar: " + fitaComplementar);
    }
}



