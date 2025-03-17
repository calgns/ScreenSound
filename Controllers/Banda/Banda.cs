using PrimeiroProjeto.Controllers.Musica;

namespace PrimeiroProjeto.Controllers.Banda;

public class BandaCLS {
    private readonly Exibir exibir = new Exibir();

    #region [Propriedades]
    public string Nome { get; }
	public string Genero { get; }
	public int AnoDeFormacao { get; }
	public List<Album> Albuns { get; }
	public List<MusicaCLS> Musicas { get; }
	public List<Integrante> Integrantes { get; }
	#endregion

	#region [Construtor]
	public BandaCLS(string nome, string genero, int anoDeFormacao, List<MusicaCLS> musicas, List<Integrante> integrantes) {
		Nome = nome;
		Genero = genero;
		AnoDeFormacao = anoDeFormacao;
		Albuns = new List<Album>();
		Musicas = new List<MusicaCLS>();
        Integrantes = new List<Integrante>();
        foreach (var musica in musicas) AdicionarMusica(musica);
		foreach (var integrante in integrantes) AdicionarIntegrante(integrante);
	}

	public Banda(string nome, string genero, int anoDeFormacao, MusicaCLS musica, Integrante integrante) {
		Nome = nome;
		Genero = genero;
		AnoDeFormacao = anoDeFormacao;
		Albuns = new List<Album>();
        Musicas = new List<MusicaCLS>();
        Integrantes = new List<Integrante>();

        AdicionarMusica(musica);
		AdicionarIntegrante(integrante);
	}

	#endregion

	#region [Métodos de Adição]
	public void AdicionarAlbum(Album album) { Albuns.Add(album); }
	public void AdicionarMusica(MusicaCLS musico) { Musicas.Add(musico); }
	public void AdicionarIntegrante(Integrante integrante) { Integrantes.Add(integrante); }
    #endregion

    #region [Métodos de Exibição]
    public void ExibirAlbuns() { exibir.Albuns(Albuns, Nome); }
    public void ExibirMusicas() { exibir.Musicas(Musicas, Nome); }
    public void ExibirIntegrantes() { exibir.Integrantes(Integrantes, Nome); }
    #endregion

    public override string ToString() { 
		return $"Nome: {Nome}, Gênero: {Genero}, Ano de Formação: {AnoDeFormacao}";
	} 
}
