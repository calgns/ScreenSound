using PrimeiroProjeto.Controllers.Banda;

namespace PrimeiroProjeto.Controllers.Musica;

public class MusicaCLS {
	private readonly Exibir exibir = new Exibir();

	#region [Propriedades]
	public float Nota { get; }
	public float Tempo { get; }
	public string Duracao { get; }
	public string NomeMusica { get; }
	public BandaCLS bandaInfo { get; }
	public List<Integrante> Integrantes { get; }
	public List<Compositor> Compositores { get; }
	public List<Patrocinadores>? Patrocinadores { get; }
	public List<ColaboradorEspecial>? ColaboradoresEspeciais { get; }
	#endregion

	#region [Construtor]
	public MusicaCLS(
		BandaCLS banda,
		string nomeMusica, 
		int duracao, 
		List<Compositor> compositores, 
		List<Integrante> integrantes, 
		List<Patrocinadores>? patrocinadores = null, 
		List<ColaboradorEspecial>? colaboradoresEspeciais = null)
	{
		Tempo = duracao;
		bandaInfo = banda;
		NomeMusica = nomeMusica;
		Integrantes = integrantes;
		Compositores = compositores;
		Patrocinadores = patrocinadores;
		ColaboradoresEspeciais = colaboradoresEspeciais;

		if(duracao >= 3600)
			Duracao = $"{TimeSpan.FromSeconds(duracao).Hours}h {TimeSpan.FromSeconds(duracao).Minutes}min {TimeSpan.FromSeconds(duracao).Minutes}s";
		else
			Duracao = $"{TimeSpan.FromSeconds(duracao).Minutes}min {TimeSpan.FromSeconds(duracao).Minutes}s";
	}
	#endregion

	#region [Métodos de Exibição]

	public void ExibirIntegrantes() {
		exibir.ExibirIntegrantes(Integrantes);
	}
	public void ExibirCompositores() {
		exibir.ExibirCompositores(Compositores);
	}
	public void ExibirPatrocinadores() {
		exibir.ExibirPatrocinadores(Patrocinadores);
	}
	public void ExibirColaboradoresEspeciais() {
		exibir.ExibirColaboradoresEspeciais(ColaboradoresEspeciais);
	}

	#endregion

	public override string ToString() {
		return $"Nome: {NomeMusica}; Banda {bandaInfo.Nome}; Duração: {Duracao}; ";
	}
}
