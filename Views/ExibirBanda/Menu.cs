using PrimeiroProjeto.Contollers.Componentes;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PrimeiroProjeto.Modelos.Banda;

namespace PrimeiroProjeto.Views.ExibirBanda;
public class Menu {
    public static void OpcoesDoMenu() {

    Inicio:
        Console.Clear();
        Logo.ExibirLogo("Screen Sound");

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
            case 1: Registrar.RegistrarBanda();     Intervalo.MeioTempo(); goto Inicio;
            case 2: Bandas.ExibirBandas();          Intervalo.MeioTempo(); goto Inicio;
            case 3: Avaliar.AvaliarBanda();         Intervalo.MeioTempo(); goto Inicio;
            case 4: Avaliacoes.ExibirAvaliacoes();  Intervalo.MeioTempo(); goto Inicio;
            case 5: Atualizar.AtualizarRegistro();                         goto Inicio;
            case 0: Console.WriteLine("Tchau tchau :)");                   break;
            default: Console.WriteLine("Opção inválida");                  goto Inicio;
        }
    }

}
