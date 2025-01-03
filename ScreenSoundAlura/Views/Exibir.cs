using System.Collections.Generic;
using System;
using PrimeiroProjeto.Contollers.Componentes;
using PrimeiroProjeto.Modelos.Banda;

namespace PrimeiroProjeto.Views;

class Exibir : Banda {
    public static string mensagemDeBoasVindas = "Boas vindas ao Screen Sound \n";
    private static Dictionary<string, List<string>> alfabetoASCII = new Dictionary<string, List<string>> {
        { "a", new List<string> { "░█████╗░", "██╔══██╗", "███████║", "██╔══██║", "██║░░██║", "╚═╝░░╚═╝" }                                      },
        { "b", new List<string> { "██████╗░", "██╔══██╗", "██████╦╝", "██╔══██╗", "██████╦╝", "╚═════╝░" }                                      },
        { "c", new List<string> { "░█████╗░", "██╔══██╗", "██║░░╚═╝", "██║░░██╗", "╚█████╔╝", "░╚════╝░" }                                      },
        { "d", new List<string> { "██████╗░", "██╔══██╗", "██║░░██║", "██║░░██║", "██████╔╝", "╚═════╝░" }                                      },
        { "e", new List<string> { "███████╗", "██╔════╝", "█████╗░░" ,"██╔══╝░░" ,"███████╗", "╚══════╝" }                                      },
        { "f", new List<string> { "███████╗", "██╔════╝", "█████╗░░", "██╔══╝░░", "██║░░░░░", "╚═╝░░░░░" }                                      },
        { "g", new List<string> { "░██████╗░", "██╔════╝░", "██║░░██╗░", "██║░░╚██╗", "╚██████╔╝", "░╚═════╝░" }                                },
        { "h", new List<string> { "██╗░░██╗", "██║░░██║", "███████║", "██╔══██║", "██║░░██║", "╚═╝░░╚═╝" }                                      },
        { "i", new List<string> { "██╗", "██║", "██║", "██║", "██║", "╚═╝" }                                                                    },
        { "j", new List<string> { "░░░░░██╗", "░░░░░██║", "░░░░░██║", "██╗░░██║", "╚█████╔╝", "░╚════╝░" }                                      },
        { "k", new List<string> { "██╗░░██╗", "██║░██╔╝", "█████═╝░", "██╔═██╗░", "██║░╚██╗", "╚═╝░░╚═╝" }                                      },
        { "l", new List<string> { "██╗░░░░░", "██║░░░░░", "██║░░░░░", "██║░░░░░", "███████╗", "╚══════╝" }                                      },
        { "m", new List<string> { "███╗░░░███╗", "████╗░████║", "██╔████╔██║", "██║╚██╔╝██║", "██║░╚═╝░██║", "╚═╝░░░░░╚═╝" }                    },
        { "n", new List<string> { "███╗░░██╗", "████╗░██║", "██╔██╗██║", "██║╚████║", "██║░╚███║", "╚═╝░░╚══╝" }                                },
        { "o", new List<string> { "░█████╗░", "██╔══██╗", "██║░░██║", "██║░░██║", "╚█████╔╝", "░╚════╝░" }                                      },
        { "p", new List<string> { "██████╗░", "██╔══██╗", "██████╔╝", "██╔═══╝░", "██║░░░░░", "╚═╝░░░░░" }                                      },
        { "q", new List<string> { "░██████╗░", "██╔═══██╗", "██║██╗██║", "╚██████╔╝", "░╚═██╔═╝░", "░░░╚═╝░░░" }                                },
        { "r", new List<string> { "██████╗░", "██╔══██╗", "██████╔╝", "██╔══██╗", "██║░░██║", "╚═╝░░╚═╝" }                                      },
        { "s", new List<string> { "░██████╗", "██╔════╝", "╚█████╗░", "░╚═══██╗", "██████╔╝", "╚═════╝░" }                                      },
        { "t", new List<string> { "████████╗", "╚══██╔══╝", "░░░██║░░░", "░░░██║░░░", "░░░██║░░░", "░░░╚═╝░░░" }                                },
        { "u", new List<string> { "██╗░░░██╗", "██║░░░██║", "██║░░░██║", "██║░░░██║", "╚██████╔╝", "░╚═════╝░" }                                },
        { "v", new List<string> { "██╗░░░██╗", "██║░░░██║", "╚██╗░██╔╝", "░╚████╔╝░", "░░╚██╔╝░░", "░░░╚═╝░░░" }                                },
        { "w", new List<string> { "░██╗░░░░░░░██╗", "░██║░░██╗░░██║", "░╚██╗████╗██╔╝", "░░████╔═████║░", "░░╚██╔╝░╚██╔╝░", "░░░╚═╝░░░╚═╝░░" }  },
        { "x", new List<string> { "██╗░░██╗", "╚██╗██╔╝", "░╚███╔╝░", "░██╔██╗░", "██╔╝╚██╗", "╚═╝░░╚═╝" }                                      },
        { "y", new List<string> { "██╗░░░██╗", "╚██╗░██╔╝", "░╚████╔╝░", "░░╚██╔╝░░", "░░░██║░░░", "░░░╚═╝░░░" }                                },
        { "z", new List<string> { "███████╗", "╚════██║", "░░███╔═╝", "██╔══╝░░", "███████╗", "╚══════╝" }                                      },
        { " ", new List<string> { " " } }
    }; public static Dictionary<string, List<string>> AlfabetoASCII { get => alfabetoASCII; set => alfabetoASCII = value; }

    public static void Logo(string titulo) {
        int linha = 0;
        string[] linhas = new string[6];
        string[] quebraDeLinha = new string[6];

        // olha se o a letra[i] do titulo é igual a letra[y] do alfabeto
        bool TemMesmaLetra(int j, int i) => AlfabetoASCII.ElementAt(j).Key.Contains(titulo[i].ToString().ToLower());

        // tamanho da linha é > que 65 e se a linha NÃO contem " "
        bool TemLetraEnaoTemEspacoApos65Char(int j, int i) => TemMesmaLetra(j, i) && (linhas[linha]?.Length > 65 ? !(linhas[linha]?.IndexOf(" ", 65) > -1) : true);

        while (linha < 6)
        {
            // Pega a 1ª letra de titulo e procura ela para pegar sua copia em ASCII
            for (int i = 0; i < titulo.Length; i++) for (int j = 0; j < AlfabetoASCII.Count; j++)
                    if (TemLetraEnaoTemEspacoApos65Char(j, i))
                        linhas[linha] += AlfabetoASCII[titulo[i].ToString().ToLower()][titulo[i].ToString().Equals(" ") ? 0 : linha];
                    else if (TemMesmaLetra(j, i))
                        quebraDeLinha[linha] += AlfabetoASCII[titulo[i].ToString().ToLower()][titulo[i].ToString().Equals(" ") ? 0 : linha];
            linha++;
        }

        foreach (string unidade in linhas) Console.WriteLine(unidade);
        foreach (string unidade in quebraDeLinha) if (unidade != null) Console.WriteLine(unidade);

        Console.WriteLine();
        Console.WriteLine(mensagemDeBoasVindas);
    }

    public static void Bandas() {
    InicioMostrar:

        Console.Clear();
        Logo(@"Catalogo das bandas");
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

        void AvaliacoesLista() {
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

        void AvaliacoesTabela() {
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

    public static void ExibirAvaliacoes()
    {
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

    public static void OpcoesDoMenu()
    {

    Inicio:
        Console.Clear();
        Logo("Screen Sound");

        Console.WriteLine("Selecione uma das opções: ");
        Console.WriteLine("  1 - Registrar uma banda;");
        Console.WriteLine("  2 - Mostrar as bandas;");
        Console.WriteLine("  3 - Avaliar uma banda;");
        Console.WriteLine("  4 - Ver avaliações das bandas;");
        Console.WriteLine("  5 - Atualizar registro de uma banda;");
        Console.WriteLine("  0 - Sair;");

        int opcaoEscolhida = Console.ReadKey()!.KeyChar - '0';
        Console.Clear();

        switch (opcaoEscolhida)
        {
            case 1: RegistrarBanda(); Intervalo.MeioTempo(); goto Inicio;
            case 2: Bandas(); Intervalo.MeioTempo(); goto Inicio;
            case 3: AvaliarBanda(); Intervalo.MeioTempo(); goto Inicio;
            case 4: ExibirAvaliacoes(); Intervalo.MeioTempo(); goto Inicio;
            case 5: AtualizarRegistro(); goto Inicio;
            case 0: Console.WriteLine("Tchau tchau :)"); break;
            default: Console.WriteLine("Opção inválida"); goto Inicio;
        }
    }

}