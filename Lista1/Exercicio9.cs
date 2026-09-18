using System;
class Exercicio9 {
    static char[] GerarComplementar(char[] Dna) {
        char[] complementar = new char[Dna.Length];
        for(int i = 0; i < Dna.Length; i++) {
            if(Dna[i] == 'A')
                complementar[i] = 'T';
            else if(Dna[i] == 'T')
                complementar[i] = 'A';
            else if(Dna[i] == 'C')
                complementar[i] = 'G';
            else if(Dna[i] == 'G')
                complementar[i] = 'C';

        }
        return complementar;
    }
    static void MostrarChar(char[] Dna) {
        for(int i = 0; i < Dna.Length; i++)
            Console.Write(Dna[i] + " ");
        Console.WriteLine();
    }
    static void Main() {
        int n;
        Console.WriteLine("Quantas bases tera o DNA: ");
        n = int.Parse(Console.ReadLine());
        if (n > 50)
            Console.WriteLine("O DNA pode ter no maximo 50 bases!");

        char[] DNA = new char[n];
        for(int i = 0; i < DNA.Length; i++){
            do{

            Console.Write($"Digite a base: {i + 1}: ");
            DNA[i] = char.Parse(Console.ReadLine().ToUpper());

            }while(DNA[i] != 'A' && DNA[i] != 'T' && DNA[i] != 'C' && DNA[i] != 'G');
             
        }
        char[] complementar = GerarComplementar(DNA);

        Console.WriteLine("\nBases do DNA: ");
        MostrarChar(DNA);
        Console.WriteLine("DNA complementar: ");
        MostrarChar(complementar);
        
        Console.WriteLine();



        
    }

}