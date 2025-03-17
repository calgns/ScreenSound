using System.Collections.Generic;
using System;
using PrimeiroProjeto.Controllers.Componentes;
using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Views.ExibirBanda;

public class Logo {
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

    public static void ExibirLogo(string titulo)
    {
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

}