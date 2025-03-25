using PrimeiroProjeto.Controllers.Musica;

namespace PrimeiroProjeto.Controllers.ColecaoMusical;

public class ExtendedPlay {

	#region [Propriedades]

	public string Nome { get; }
	public List<MusicaCLS> Musicas { get; }
	public float DuracaoTotal => Musicas.Sum(m => m.Tempo);

	#endregion

	#region [Construtor]

	public ExtendedPlay(string nome, List<MusicaCLS> musicas) {
		Nome = nome;
		Musicas = musicas;
	}

	#endregion
}
