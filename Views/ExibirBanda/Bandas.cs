using PrimeiroProjeto.Controllers.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Views.ExibirBanda;
public class Bandas {
    public static void ExibirBandas() {
    InicioMostrar:

        Console.Clear();
        Logo.ExibirLogo(@"Catalogo das bandas");
        Console.WriteLine("Veja as suas bandas aqui! \n");
        Console.WriteLine("Aqui jas " + DB.ListaDasBandas.Count + " bandas! \n");

        int EncontreMaior()
        {
            int vlrMaior = 0;
            for (int i = 0; i < DB.ListaDasBandas.Count(); i++)
            {
                int vlrAtual = DB.ListaDasBandas.ElementAt(i).Key.Length;
                vlrMaior = vlrAtual > vlrMaior ? vlrAtual : vlrMaior;
            }
            return vlrMaior;
        }

        void AvaliacoesLista()
        {
            int indentacao = EncontreMaior();
            foreach (KeyValuePair<string, List<double>> banda in DB.ListaDasBandas)
            {
                string msg = $"{banda.Key}: ";
                double media = banda.Value.Count > 0 ? banda.Value.Aggregate((atual, proximo) => atual + proximo) / banda.Value.Count : 0;

                if (indentacao > banda.Key.Length) { for (int i = banda.Key.Length; i < indentacao; i++) msg += " "; }

                Console.Write(msg);
                Console.WriteLine(string.Format("[{0} Avaliações] [Média {1:0.00}]", banda.Value.Count, media));
            }
        }

        void AvaliacoesTabela()
        {
            int indentacao = EncontreMaior();
            void Linhas(string x = "-", int y = 61) { Console.Write("|"); for (int i = 0; i < y; i++) Console.Write(x); Console.WriteLine("|"); } // use => somente quando for ocultar o "{corpo}", parentases.
            Linhas("=");
            Console.WriteLine(string.Format("|{0} {1," + (14 + indentacao) + "} {2,20} |", "Bandas", "Avaliações", "Média"));
            Linhas("+");

            foreach (KeyValuePair<string, List<double>> banda in DB.ListaDasBandas)
            {
                int tabulacao = 0;
                double media = banda.Value.Count > 0 ? banda.Value.Aggregate((atual, proximo) => atual + proximo) / banda.Value.Count : 0;
                if (indentacao > banda.Key.Length) { for (int i = banda.Key.Length; i < indentacao; i++) tabulacao++; }
                if (banda.Key != "U2") Linhas();
                Console.WriteLine(string.Format("| {0} {1," + (15 + tabulacao) + "} {2,24:0.00} |", banda.Key, banda.Value.Count, media));
            }
            Linhas("=");
        }

        AvaliacoesLista();

        Console.WriteLine("Em qual formato você gostaria de ver as bandas? \nEscolha uma das opções ou digite \"0\" para voltar! \n  1 - Tabela; \n  2 - Lista;");
        int opcaoEscolhida = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine("\n\n");

        if (opcaoEscolhida == 0) return;
        else if (opcaoEscolhida == 1) { AvaliacoesTabela(); Intervalo.MeioTempo(); goto InicioMostrar; }
        else if (opcaoEscolhida == 2) { AvaliacoesLista(); Intervalo.MeioTempo(); goto InicioMostrar; }
        else { Console.WriteLine("Opção invalida! Por favor selecione uma opção!"); Intervalo.MeioTempo(); goto InicioMostrar; }

    }
}

