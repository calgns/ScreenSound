using PrimeiroProjeto.Controllers.Musica;

namespace PrimeiroProjeto.Controllers.ColecaoMusical;

public class Colecao {


	#region [Propriedades]

	public string Nome { get; }
	public List<MusicaCLS> Musicas { get; }
	public float DuracaoTotal => Musicas.Sum(m => m.Tempo);

	#endregion

	#region [Construtor]

	public Colecao(string nome, List<MusicaCLS> musicas) {
		Nome = nome;
		Musicas = musicas;
	}

	#endregion

	public virtual void  ExibirMusicas(List<MusicaCLS> musicas, string nomeBanda) {
		if (musicas.Count > 1) {
			Console.WriteLine($"Musicas da banda {nomeBanda}: ");
			for (int i = 0; i < musicas.Count; i++)
				Console.WriteLine($"  {i + 1} - {musicas[i].NomeMusica};");

		}
		else if (musicas.Count == 1)
			Console.WriteLine($"A banda {nomeBanda} possui apenas uma musica: {musicas[0].NomeMusica}");
		else
			Console.WriteLine($"Não foi encontrado nenhuma musica da banda {nomeBanda}!");
	}

}
