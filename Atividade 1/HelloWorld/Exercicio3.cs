using System;

class Exercicio3
{
    static void Main()
    {
        double n, soma = 0, cont = 0;
        for(int i=0; i<6; i++)
        {
            n = double.Parse(Console.ReadLine());
            if(n > 0)
            {
                soma += n;
                cont++;
            }
        }
        Console.WriteLine($"{cont} valores positivos");
        Console.WriteLine($"{(soma/cont):f1}");
    }
}