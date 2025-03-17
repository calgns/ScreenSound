using PrimeiroProjeto.Controllers.Musica;

namespace PrimeiroProjeto.Controllers.Banda;
public class Exibir : IExibir {
    public void Albuns(List<Album> albuns, string nomeBanda) {
        if (albuns.Count > 1) {
            Console.WriteLine($"Albuns da banda {nomeBanda}: ");
            for (int i = 0; i < albuns.Count; i++) {
                Console.WriteLine($"  {i + 1} - {albuns[i].Name};");
            } 
        }
        else if(albuns.Count == 1) 
            Console.WriteLine($"A banda {nomeBanda} possui apenas um album: {albuns[0].Name}");
        else 
            Console.WriteLine($"Não foi encontrado nenhum album da banda {nomeBanda}!");
    }

    public void Musicas(List<MusicaCLS> musicas, string nomeBanda) {
        if (musicas.Count > 1) {
            Console.WriteLine($"Musicas da banda {nomeBanda}: ");
            for (int i = 0; i < musicas.Count; i++) {
                Console.WriteLine($"  {i + 1} - {musicas[i].NomeMusica};");
            }
        }
        else if (musicas.Count == 1)
            Console.WriteLine($"A banda {nomeBanda} possui apenas uma musica: {musicas[0].NomeMusica}");
        else
            Console.WriteLine($"Não foi encontrado nenhuma musica da banda {nomeBanda}!");
    }

    public void Integrantes(List<Integrante> integrantes, string nomeBanda) {
        if (integrantes.Count > 1) {
            Console.WriteLine($"Integrantes da banda {nomeBanda}: ");
            for (int i = 0; i < integrantes.Count; i++) {
                Console.WriteLine($"  {i + 1} - {integrantes[i].Nome};");
            }
        }
        else if (integrantes.Count == 1)
            Console.WriteLine($"A banda {nomeBanda} possui apenas um integrante: {integrantes[0].Nome}");
        else
            Console.WriteLine($"Não foi encontrado nenhum integrante da banda {nomeBanda}!");
    }

}
