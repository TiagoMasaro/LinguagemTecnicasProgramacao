using System;
using BibliotecaMatriz;

class Exercicio10
{
    static long EncontrarArea(int[,] dados)
    {
        int quantidade = dados.GetLength(0);

        int[] coordenadasX = new int[quantidade * 2];
        int[] coordenadasY = new int[quantidade * 2];

        for (int indice = 0; indice < quantidade; indice++)
        {
            coordenadasX[indice * 2] = dados[indice, 0];
            coordenadasX[indice * 2 + 1] = dados[indice, 2];

            coordenadasY[indice * 2] = dados[indice, 1];
            coordenadasY[indice * 2 + 1] = dados[indice, 3];
        }

        Array.Sort(coordenadasX);
        Array.Sort(coordenadasY);

        long resultado = 0;

        for (int x = 0; x < coordenadasX.Length - 1; x++)
        {
            for (int y = 0; y < coordenadasY.Length - 1; y++)
            {
                double pontoX = (coordenadasX[x] + coordenadasX[x + 1]) / 2.0;
                double pontoY = (coordenadasY[y] + coordenadasY[y + 1]) / 2.0;

                bool pertence = false;

                for (int retangulo = 0; retangulo < quantidade; retangulo++)
                {
                    bool estaNoRetangulo =
                        pontoX >= dados[retangulo, 0] &&
                        pontoX < dados[retangulo, 2] &&
                        pontoY >= dados[retangulo, 1] &&
                        pontoY < dados[retangulo, 3];

                    if (estaNoRetangulo)
                    {
                        pertence = true;
                        break;
                    }
                }

                if (pertence)
                {
                    long baseRetangulo =
                        coordenadasX[x + 1] - coordenadasX[x];

                    long alturaRetangulo =
                        coordenadasY[y + 1] - coordenadasY[y];

                    resultado += baseRetangulo * alturaRetangulo;
                }
            }
        }

        return resultado;
    }

    static void Main()
    {
        Console.Write("Quantidade de retângulos: ");
        int quantidade = int.Parse(Console.ReadLine());

        int[,] retangulos = new int[quantidade, 4];

        Matriz.lerMatriz(retangulos);

        long areaTotal = EncontrarArea(retangulos);

        Console.WriteLine($"Área total: {areaTotal}");
    }

}