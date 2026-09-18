using System;
class Exercicio8 {
    static void InverterVetor(char[] vetor, int x) {
        for(int i = x; i >=0; i--){
            Console.Write(vetor[i]);
        } 
    }
    static void Main(){
        string txt;
        int qtdElementos;
        Console.WriteLine("\nEntre como texto: ");
        txt = Console.ReadLine();
        char[] vetor = txt.ToCharArray();
        qtdElementos = vetor.Length;
        Console.WriteLine("\nTexto invertido: ");
        InverterVetor(vetor, qtdElementos -1);
        
    }
}