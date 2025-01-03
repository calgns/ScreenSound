using PrimeiroProjeto.Contollers.Componentes;
using PrimeiroProjeto.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Modelos.Banda;

partial class Banda {
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
