using System;

class Exercicio1
{
    static void Main()
    {
        double raio, n, area;
        n = 3.14159;

        raio = double.Parse(Console.ReadLine());

        area = n * (raio * raio);
        Console.WriteLine($"A={area:f4}");
    }
}