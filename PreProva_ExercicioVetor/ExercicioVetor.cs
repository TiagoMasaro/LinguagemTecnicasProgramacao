using System;

class ExercicioVetor
{
    static double calcularMedia(int[] roubos)//criação de uma função double para calcular a Média de roubos
    {
        double soma = 0;

        for (int i = 0; i < roubos.Length; i++)//percorre as posições do vetor
        {
            soma += roubos[i];//somar a quantidade de roubos
        }

        return soma / roubos.Length;//efetua o calculo da media
    }

    static void exibirTop3BairrosViolentos(string[] bairros, int[] roubos)//cricao de uma funcao void para exibir os 3 bairros mais violentos
    {
        // -1 significa que ainda não temos nenhum índice armazenado
        // Como os índices começam em 0, -1 não é um índice válido
        int maior1 = -1; //Não possui nenhum índice
        int maior2 = -1;
        int maior3 = -1;

        for (int i = 0; i < roubos.Length; i++) // Percorre o vetor de roubos
        {
            // Verifica se ainda não temos o primeiro maior ou se o valor atual é maior que o primeiro maior
            if (maior1 == -1 || roubos[i] > roubos[maior1])
            {
                maior3 = maior2; // O segundo maior passa a ser o terceiro
                maior2 = maior1; // O primeiro maior passa a ser o segundo
                maior1 = i; // O valor atual vira o primeiro maior
            }
            else if (maior2 == -1 || roubos[i] > roubos[maior2]) // Verifica se o valor atual é o segundo maior
            {
                maior3 = maior2; // O segundo maior antigo passa para terceiro
                maior2 = i; // O valor atual vira o segundo maior
            }
            else if (maior3 == -1 || roubos[i] > roubos[maior3]) // Verifica se o valor atual é o terceiro maior
            {
                maior3 = i; // O valor atual vira o terceiro maior
            }
        }

        Console.WriteLine("--- TOP 3 BAIRROS MAIS VIOLENTOS ---"); //Exibirá a colocação de cada bairro

        Console.WriteLine("1o Lugar: " + bairros[maior1] + " (Índice " + maior1 + ") - " + roubos[maior1] + " roubos");
        Console.WriteLine("2o Lugar: " + bairros[maior2] + " (Índice " + maior2 + ") - " + roubos[maior2] + " roubos");
        Console.WriteLine("3o Lugar: " + bairros[maior3] + " (Índice " + maior3 + ") - " + roubos[maior3] + " roubos");
    }
    static void Main()
    {
        string[] bairros = {
                        "Centro",
                        "Moema",
                        "Pinheiros",
                        "Itaquera",
                        "Tatuapé",
                        "Santo Amaro",
                        "Vila Mariana",
                        "Lapa",
                        "Capão Redondo",
                        "Santana"
                    };

        int[] vetorRoubos = { 350, 120, 210, 480, 190, 310, 150, 280, 520, 240 };

        Console.WriteLine("=== ANÁLISE DE SEGURANÇA PÚBLICA - BAIRROS DE SP ===");

        double media = calcularMedia(vetorRoubos); //chama a funcao
        Console.WriteLine("Média de roubos por bairro: " + media.ToString("F2") + " ocorrências");
        exibirTop3BairrosViolentos(bairros, vetorRoubos); //chama a funcao
    }

}


