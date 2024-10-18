
using System.Collections.Generic;
using System;

static class Banda {
    public static void Registrar() {
        Exibir.Logo(@"Registro de bandas");
        Console.WriteLine("Registre uma banda aqui!\n");
        Console.Write("Dê o nome da banda a ser registrada: ");
        string banda = Console.ReadLine()!;
        DB.ListaDasBandas.Add(banda, new List<double>());

        Console.WriteLine($"\nA {banda} foi adicionada com sucesso!");
        Console.WriteLine("\nEis aqui todas as bandas:");
        foreach (string chave in DB.ListaDasBandas.Keys) { Console.WriteLine($"  - {chave}"); }
    }

    public static void Avaliar() {
      InicioAvaliacao:
        Console.Clear();
        Exibir.Logo(@"Avaliacao De Bandas");
        Console.WriteLine("Avalie uma banda aqui! \n");

        // Variaveis
        static KeyValuePair<string, List<Double>> PegaBanda(int i) => DB.ListaDasBandas.ElementAt(i);

        // Mostra as bandas para o usuario e pede para escolher uma
        Console.WriteLine("Qual a banda a ser avaliada? \nEscolha uma das opções ou digite \"0\" para voltar!");
        for (int i = 0; i < DB.ListaDasBandas.Count; i++) { Console.WriteLine($"  {i + 1} - {PegaBanda(i).Key}"); }
        Console.WriteLine();
        int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

        // Caso não escolha, retorna a função ou se escolher uma opção invalida/inexistente, Chama InicioAvaliacao
        if (opcao == 0) return;
        else if (opcao > DB.ListaDasBandas.Count || opcao < 0) { Console.WriteLine("Por favor escolha uma das opções!"); Intervalo.MeioTempo(); Console.Clear(); goto InicioAvaliacao; }

        // Espera a confirmação do usuario, quanto a sua escolha
        Console.WriteLine($"Você escolheu a {opcao}º opção, que é {PegaBanda(opcao - 1).Key}. ");
        Console.WriteLine("Tem certeza? \n  0 - Sim; \n  1 - Não;");
        int certeza = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

        // Com base em "certeza" realiza o codigo ou volta ao inicio
        if (certeza == 0) {
            // Pede a nota a ser dada e a formata trocando "." por "," e para Double
            Console.WriteLine("Qual a nota a ser dada?");
            string avaliacao = Console.ReadLine()!;
            double avaliacaoFormatada = double.Parse((avaliacao.Contains('.')) ? avaliacao.Replace(".", ",") : avaliacao);

            if (avaliacaoFormatada < 1 || avaliacaoFormatada > 10) { Console.WriteLine("A nota deve ser de no minimo 1 e no maximo 10!"); Intervalo.MeioTempo(); goto InicioAvaliacao; }

            // Adiciona a avaliação
            DB.ListaDasBandas[PegaBanda(opcao - 1).Key].Add(avaliacaoFormatada);

            // Mostra a banda que foi avaliada
            Console.Write($"\nAvalição concluida! \n{PegaBanda(opcao - 1).Key}: ");
            foreach (double nota in PegaBanda(opcao - 1).Value) Console.Write($"({nota}) ");
        }
        else goto InicioAvaliacao;
    }

    static void AtualizarNome(int banda) {
        string bandaAntiga = DB.ListaDasBandas.ElementAt(banda - 1).Key;
        Console.WriteLine("Qual o nome você gostaria de a dar?");
        string novaBanda = Console.ReadLine()!;

        Console.WriteLine($"\n{bandaAntiga} vai ser substituido por {novaBanda} \n");

        Console.WriteLine("Tem certeza? \n  0 - Sim; \n  1 - Não;");
        int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

        if (opcao == 0) Utils.GirarChave(DB.ListaDasBandas, bandaAntiga, novaBanda);
    }

    public static void AtualizarRegistro() {
      InicioAtualizar:
        Console.Clear();
        Exibir.Logo("Atualizacao de registros");
        Console.WriteLine("Atualize aqui o nome da banda ou a nota dela! \n");

        // Mostra as bandas e pede para escolher
        Console.WriteLine("Qual das bandas você quer atualizar? \nEscolha uma das opções ou digite \"0\" para voltar!");
        for (int i = 0; i < DB.ListaDasBandas.Count; i++) Console.WriteLine($"  {i + 1} - {DB.ListaDasBandas.ElementAt(i).Key}; ");
        int bandaEscolhida = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

        // Retorna se o usuario não tiver escolhido nenhuma ou volta ao inicio se a opção for invalida!
        if (bandaEscolhida == 0) return;
        else if (bandaEscolhida < 0) { Console.WriteLine("Opção invalida! \nPor favor escolha uma das opções apresentadas!"); Intervalo.MeioTempo(); goto InicioAtualizar; }

        // Pede que escolha o que vai atualizar
        Console.WriteLine("Atualizar o nome ou nota? \n  1 - Nome; \n  2 - Nota; \n  3 - Nome e Nota;");
        int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

        // Chama a função com base na opção escolhida pelo usuario
        switch (opcao) {
            case 1: AtualizarNome(bandaEscolhida); break;
            case 2: Utils.GirarNota(bandaEscolhida); break;
            case 3: AtualizarNome(bandaEscolhida); Utils.GirarNota(bandaEscolhida); break;
        }
    }
}
