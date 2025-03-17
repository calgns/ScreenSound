using PrimeiroProjeto.Controllers.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Views.ExibirBanda;
public class Avaliacoes {
    public static void ExibirAvaliacoes() {
        Logo("Avaliacoes");
        Console.WriteLine("Veja aqui as avaliações das bandas!");
        // Atenção é utilizada a Media Aritimética, e apenas, pois, o calculo que deve ser realizado para calcular a media das avaliações é um calculo para encontrar a nota mais comum.
        // Que é atendido apenas pela Media Aritimética.

        Console.WriteLine("Aqui jas " + DB.ListaDasBandas.Count + " bandas!");
        foreach (KeyValuePair<string, List<double>> banda in DB.ListaDasBandas)
        {
            // Variaveis
            string nomeDaBanda = banda.Key;
            List<double> notas = banda.Value;

            // Soma as avaliações para ser utilzado no calculo da media, senão tiver, o valor dado é "0"
            double somaAvalicoes = banda.Value.Count > 0 ? banda.Value.Aggregate((atual, proximo) => atual + proximo) : 0;

            // Calcula a media se houver notas, senão, o valor dado é "0"
            double media = notas.Count > 0 ? somaAvalicoes / notas.Count : 0;

            // Formata a nota para que não tenha ","
            string formataAvaliacao(int i) => notas[i].ToString().Contains(',') ? notas[i].ToString().Replace(",", ".") : notas[i].ToString();

            // Mostra as bandas e formata a media para duas casas apos a virgula e apenas
            Console.WriteLine("\n" + nomeDaBanda + ": ");
            Console.WriteLine(string.Format("  - Media das Avaliações: {0:0.00}", media));

            // Se hover avaliações adiciona somente a string, senão, quebra a linha
            Console.Write(notas.Count > 0 ? "  - Avaliações: " : "  - Sem avaliações;\n");

            // Exibe as avalições formatadas
            for (int i = 0; i < notas.Count; i++) Console.Write(banda.Value.Count > i + 1 ? $"({formataAvaliacao(i)}), " : $"({formataAvaliacao(i)}); \n");
            Console.WriteLine($"  - {notas.Count} Avaliações!");
        }
    }

}

