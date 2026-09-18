using System;
class Exercicio12{
     static double obterMaiorNota(double[] notas){
        double MaiorNota = notas[0];
        for(int i = 0; i < notas.Length; i++) {
            if(notas[i] > MaiorNota) {
                MaiorNota = notas[i];
            }
        } 
        return MaiorNota;
    }
    static double obterMenorNota(double[] notas){
        double MenorNota = notas[0];
        for(int i = 0; i < notas.Length; i++) {
            if(notas[i] < MenorNota) {
                MenorNota = notas[i];
            }
        } 
        return MenorNota;
    }
    static double calcularSomaNotas(double[] notas) {
        double somarNotas = 0;
        for(int i = 0; i < notas.Length; i++){
            somarNotas += notas[i];
        } 
        return somarNotas;   
    }
     static double calcularNotaFinal(double[] notas) {
        return calcularSomaNotas(notas) - obterMaiorNota(notas) - obterMenorNota(notas);
    }
    static void Main(){
        double[] notas = new double[5];
        for(int i = 0; i < notas.Length; i++) {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
            
        }
        Console.WriteLine(obterMaiorNota(notas));
        Console.WriteLine(obterMenorNota(notas));
        Console.WriteLine(calcularSomaNotas(notas));
        Console.WriteLine(calcularNotaFinal(notas));
    }
}