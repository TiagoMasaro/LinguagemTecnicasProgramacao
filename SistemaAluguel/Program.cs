using System;
using LocadoraCarros;

class Program{
	
	
	  static void salvarDados(List<CarroAluguel> listaCarros, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);
        foreach (CarroAluguel c in listaCarros)
        {
            writer.WriteLine($"{c.modelo};{c.placa};{c.ano};{c.valorDiaria};{c.alugado}");
        }
        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }

    static void carregarDados(List<CarroAluguel> listaCarros, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhasDoArquivo)
            {
                string[] campos = linha.Split(';');
                CarroAluguel c = new CarroAluguel();
                c.modelo = campos[0];
                c.placa = campos[1];
                c.ano = int.Parse(campos[2]);
                c.valorDiaria = double.Parse(campos[3]);
                c.alugado = bool.Parse(campos[4]);
                listaCarros.Add(c);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo CSV não encontrado :(");
        }
    }

    static void addCarro(List<CarroAluguel> listaCarros)
    {
        CarroAluguel novoCarro = new CarroAluguel();
        Console.WriteLine("=== CADASTRAR NOVO CARRO ===");
        Console.Write("Modelo do veículo: ");
        novoCarro.modelo = Console.ReadLine();
        Console.Write("Placa do veículo: ");
        novoCarro.placa = Console.ReadLine();
        Console.Write("Ano de fabricação: ");
        novoCarro.ano = int.Parse(Console.ReadLine());
        Console.Write("Valor da diária (R$): ");
        novoCarro.valorDiaria = double.Parse(Console.ReadLine());
        Console.Write("Está alugado no momento? (1-Sim / 2-Não): ");
        int opAlugado = int.Parse(Console.ReadLine());
        novoCarro.alugado = (opAlugado == 1);
        listaCarros.Add(novoCarro);
        Console.WriteLine("Carro cadastrado com sucesso!");
    }

    static void mostrarCarros(List<CarroAluguel> listaCarros)
    {
        Console.WriteLine("=== FROTA COMPLETA DE VEÍCULOS ===");
        for (int i = 0; i < listaCarros.Count; i++)
        {
            string status = listaCarros[i].alugado ? "ALUGADO" : "DISPONÍVEL";
            Console.WriteLine($"[{i + 1}] {listaCarros[i].modelo} | Placa: {listaCarros[i].placa} | Ano: {listaCarros[i].ano} | Diária: R$ {listaCarros[i].valorDiaria:F2} | Status: {status}");
        }
    }
	
	  static bool buscarPorPlaca(List<CarroAluguel> listaCarros, string placaBusca)
    {
		bool encontrado = false;
		for(int i = 0; i < listaCarros.Count; i++){
			if(listaCarros[i].placa.ToUpper().Contains(placaBusca.ToUpper()))
			{
				Console.WriteLine("---Carro---");
				Console.WriteLine($"Modelo: {listaCarros[i].modelo}");
				Console.WriteLine($"Placa: {listaCarros[i].placa}");
				Console.WriteLine($"Ano: {listaCarros[i].ano}");
				Console.WriteLine($"Condição: {listaCarros[i].alugado}");
				
			}
		}
        return encontrado;
    }
	
	 static void verificarMaiorMenorValor(List<CarroAluguel> listaCarros)
    {
        // 1. Inicialize carroMaior e carroMenor recebendo o primeiro carro da lista: listaCarros[0]
        // 2. Percorra a lista com um laço for comparando listaCarros[i].valorDiaria
        //    - Se for maior que carroMaior.valorDiaria, atualize carroMaior
        //    - Se for menor que carroMenor.valorDiaria, atualize carroMenor
        // 3. Fora do laço, exiba os dados completos do carro de MAIOR diária e do carro de MENOR diária
		


    }

	static void mostrarCarrosDisponiveis(List<CarroAluguel> listaCarros)
	{
		for (int i = 0; i < listaCarros.Count; i++)
		{
			if (listaCarros[i].alugado == false)
			{
				Console.WriteLine("Carro: " + listaCarros[i].modelo);
				Console.WriteLine("Placa: " + listaCarros[i].placa);
				Console.WriteLine("----------------------");
			}
		}
	}

    static void mostrarCarrosAlugados(List<CarroAluguel> listaCarros)
    {
        // Percorra a listaCarros e exiba APENAS os veículos em que alugado == true (alugados)











    }


	
	 static int menu()
    {
        Console.WriteLine("=== SISTEMA DE ALUGUEL DE CARROS ===");
        Console.WriteLine("1 - Cadastrar Novo Carro");
        Console.WriteLine("2 - Mostrar Todos os Carros da Frota");
        Console.WriteLine("3 - Buscar Carro pela Placa");
        Console.WriteLine("4 - Verificar Carro de Maior e Menor Valor de Aluguel");
        Console.WriteLine("5 - Mostrar Apenas Carros Disponíveis");
        Console.WriteLine("6 - Mostrar Apenas Carros Alugados");
        Console.WriteLine("0 - Salvar e Sair");
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

	
	static void Main()
    {
        List<CarroAluguel> listaCarros = new List<CarroAluguel>();
        carregarDados(listaCarros, "carros.csv");

        int opcao;
        do
        {
            opcao = menu();
            switch (opcao)
            {
                case 1:
                    addCarro(listaCarros);
                    break;
                case 2:
                    mostrarCarros(listaCarros);
                    break;
                case 3:
					Console.WriteLine("Digite a placa que deseja consultar: ");
					string placaBusca = Console.ReadLine();
					bool encontrado = buscarPorPlaca(listaCarros, placaBusca);
					if (!encontrado)
					Console.WriteLine("Placa não encontrada!");
                    break;
                case 4:
                    // Chame a função verificarMaiorMenorValor

                    break;
                case 5:
                    mostrarCarrosDisponiveis(listaCarros);
                    break;
                case 6:
                    // Chame a função mostrarCarrosAlugados

                    break;
                case 0:
                    Console.WriteLine("Salvando dados e encerrando...");
                    salvarDados(listaCarros, "carros.csv");
                    break;
            }// fim switch
            Console.ReadKey();
            Console.Clear();
        } while (opcao != 0);
    }// fim main
}
