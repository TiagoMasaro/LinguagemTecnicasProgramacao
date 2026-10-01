using System;
using BibliotecaMatriz;

class Exercicio6
{
    static void ExibirMatriz(double[,] matriz)
    {
        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                Console.Write($"{matriz[linha, coluna],6}| ");
            }

            Console.WriteLine();
        }
    }

    static void PreencherMatriz(double[,] matriz)
    {
        Random gerador = new Random();

        for (int linha = 0; linha < matriz.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                matriz[linha, coluna] = gerador.NextDouble() * 100;
            }
        }
    }

    static double[,] Somar(double[,] primeira, double[,] segunda)
    {
        int linhas = primeira.GetLength(0);
        int colunas = primeira.GetLength(1);

        double[,] resultado = new double[linhas, colunas];

        for (int linha = 0; linha < linhas; linha++)
        {
            for (int coluna = 0; coluna < colunas; coluna++)
            {
                resultado[linha, coluna] =
                    primeira[linha, coluna] + segunda[linha, coluna];
            }
        }

        return resultado;
    }

    static double[,] Subtrair(double[,] primeira, double[,] segunda)
    {
        int linhas = primeira.GetLength(0);
        int colunas = primeira.GetLength(1);

        double[,] resultado = new double[linhas, colunas];

        for (int linha = 0; linha < linhas; linha++)
        {
            for (int coluna = 0; coluna < colunas; coluna++)
            {
                resultado[linha, coluna] =
                    segunda[linha, coluna] - primeira[linha, coluna];
            }
        }

        return resultado;
    }

    static void Main()
    {
        Console.Write("\nNumero de linhas da Matriz: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.Write("Numero de colunas da Matriz: ");
        int colunas = int.Parse(Console.ReadLine());

        double[,] matrizA = new double[linhas, colunas];
        double[,] matrizB = new double[linhas, colunas];

        PreencherMatriz(matrizA);
        PreencherMatriz(matrizB);

        Console.WriteLine("\nMatrize A:");
        ExibirMatriz(matrizA);

        Console.WriteLine("\nMatrize B:");
        ExibirMatriz(matrizB);

        char opcao;

        do
        {
            Console.WriteLine("\n---MENU DE OPÇÕES---\n");
            Console.WriteLine("(A) somar as duas matrizes.");
            Console.WriteLine("(B) subtrair a primeira matriz da segunda.");
            Console.WriteLine("(C) adicionar uma constante as duas matrizes.");
            Console.WriteLine("(D) imprimir as matrizes.");
            Console.WriteLine("(E) sair.");

            Console.Write("\nQual opção deseja: ");
            opcao = char.ToUpper(char.Parse(Console.ReadLine()));

            switch (opcao)
            {
                case 'A':
                    Console.WriteLine("\nSoma das Matrizes.");

                    double[,] resultadoSoma = Somar(matrizA, matrizB);
                    ExibirMatriz(resultadoSoma);

                    Console.WriteLine("-------------------------------------------------------------------");
                    break;

                case 'B':
                    Console.WriteLine("\nSubtração das Matrizes.");

                    double[,] resultadoSubtracao = Subtrair(matrizA, matrizB);
                    ExibirMatriz(resultadoSubtracao);

                    Console.WriteLine("-------------------------------------------------------------------");
                    break;

                case 'C':
                    Console.WriteLine("\nAdicionar uma constente.");
                    Console.Write("Digite a constante: ");

                    double valor = double.Parse(Console.ReadLine());

                    for (int linha = 0; linha < linhas; linha++)
                    {
                        for (int coluna = 0; coluna < colunas; coluna++)
                        {
                            matrizA[linha, coluna] += valor;
                            matrizB[linha, coluna] += valor;
                        }
                    }

                    break;

                case 'D':
                    Console.WriteLine("\nImprimir as matrizes.");

                    Console.WriteLine("\nMatriz A:");
                    ExibirMatriz(matrizA);

                    Console.WriteLine("\nMatriz B:");
                    ExibirMatriz(matrizB);

                    Console.WriteLine("-----------------------------------------------------------------");
                    break;

                case 'E':
                    Console.WriteLine("\nSaindooo....");
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

        } while (opcao != 'E');
    }

}