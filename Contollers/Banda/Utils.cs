using System;
using System.Collections.Generic;

namespace PrimeiroProjeto.Contollers.Banda;
class Utils {
    public static void GirarChave(Dictionary<string, List<double>> dict, string velhaChave, string novaChave) {
        if (dict.ContainsKey(velhaChave)) { // Confere se existe e substitui a chave antiga pela nova
            List<double> valores = dict[velhaChave];
            dict.Remove(velhaChave);
            dict[novaChave] = valores; // dict.Add(novaChave, valores);
            Console.WriteLine("Banda atualizada com sucesso!");
        } else Console.WriteLine($"A banda {velhaChave} não foi encontrada!");
    }
    public static void GirarNota(int banda) {
        // Variaveis
        int qtdAvalicoes = DB.ListaDasBandas.ElementAt(banda - 1).Value.Count;
        KeyValuePair<string, List<double>> bandaAtual = DB.ListaDasBandas.ElementAt(banda - 1);
        // double Nota(int i) => bandaAtual.Value[i];

        if (bandaAtual.Value.Count == 0) { Console.WriteLine("\nEsta banda não possui notas que possam ser substituidas..."); Intervalo.MeioTempo(); return; }

        Console.WriteLine($"Qual das notas gostaria de atualizar?");
        // Opções exibidas e entrada do mesmo
        for (int i = 0; i < qtdAvalicoes; i++) Console.WriteLine($"  {i + 1} - {bandaAtual.Value[i]}");
        int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

        // Novo valor pego
        Console.WriteLine("Informe o novo valor!");
        string avaliacao = Console.ReadLine()!;

        // Formatação de "." para "," e transforma em Double
        double avaliacaoFormatada = double.Parse(avaliacao.Contains(".") ? avaliacao.Replace(".", ",") : avaliacao);

        // Atualiza o valor na listaDasBandas
        DB.ListaDasBandas[bandaAtual.Key][opcao - 1] = avaliacaoFormatada;
        Console.WriteLine("Avalição atualizada com sucesso!");

        // Mostra a alteração feita
        Console.WriteLine($"{bandaAtual.Key} possui {qtdAvalicoes} Avalições");
        for (int i = 0; i < qtdAvalicoes; i++) Console.WriteLine($"  {i + 1} - {bandaAtual.Value[i]}");
        Intervalo.MeioTempo();
    }
}
