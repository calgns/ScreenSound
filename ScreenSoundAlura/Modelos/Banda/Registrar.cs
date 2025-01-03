using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System;
using PrimeiroProjeto.Views;
using PrimeiroProjeto.Contollers.Componentes;

namespace PrimeiroProjeto.Modelos.Banda;

partial class Banda {
    public static void RegistrarBanda() {
        Exibir.Logo(@"Registro de bandas");
        Console.WriteLine("Registre uma banda aqui!\n");
        Console.Write("Dê o nome da banda a ser registrada: ");
        string banda = Console.ReadLine()!;
        DB.ListaDasBandas.Add(banda, new List<double>());

        Console.WriteLine($"\nA {banda} foi adicionada com sucesso!");
        Console.WriteLine("\nEis aqui todas as bandas:");
        foreach (string chave in DB.ListaDasBandas.Keys) { Console.WriteLine($"  - {chave}"); }
    }
}
