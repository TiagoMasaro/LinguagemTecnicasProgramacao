using System;
class Exercicio11 {
    static String Decodificar(String codificada){
    char[] decodificada = new char[codificada.Length];
    int j = 0;
    for(int i = 0; i < codificada.Length; i++) {
            if(codificada[i] != 'p'){
                decodificada[j] = codificada[i];
                j++;
            }
            else if(i != 0 && i != codificada.Length-1 && codificada[i+1] == 'p' && codificada[i-1] == 'p'){
                decodificada[j] = codificada[i];
                j++;
            }
        }
    return new String(decodificada);
    }
    static void Main() {
        string codificada;
        Console.WriteLine("Digite a mensagem!");
        codificada = Console.ReadLine();
        Console.WriteLine(Decodificar(codificada));



    }
}