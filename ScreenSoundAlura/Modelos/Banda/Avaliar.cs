using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeiroProjeto.Views;
using PrimeiroProjeto.Contollers.Componentes;

namespace PrimeiroProjeto.Modelos.Banda;

partial class Banda {
    public static void AvaliarBanda() {
    InicioAvaliacao:
        Console.Clear();
        Exibir.Logo(@"Avaliacao De Bandas");
        Console.WriteLine("Avalie uma banda aqui! \n");

        // Variaveis
        static KeyValuePair<string, List<double>> PegaBanda(int i) => DB.ListaDasBandas.ElementAt(i);

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
            double avaliacaoFormatada = double.Parse(avaliacao.Contains('.') ? avaliacao.Replace(".", ",") : avaliacao);

            if (avaliacaoFormatada < 1 || avaliacaoFormatada > 10) { Console.WriteLine("A nota deve ser de no minimo 1 e no maximo 10!"); Intervalo.MeioTempo(); goto InicioAvaliacao; }

            // Adiciona a avaliação
            DB.ListaDasBandas[PegaBanda(opcao - 1).Key].Add(avaliacaoFormatada);

            // Mostra a banda que foi avaliada
            Console.Write($"\nAvalição concluida! \n{PegaBanda(opcao - 1).Key}: ");
            foreach (double nota in PegaBanda(opcao - 1).Value) Console.Write($"({nota}) ");
        }
        else goto InicioAvaliacao;
    }

}
