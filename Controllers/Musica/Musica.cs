using PrimeiroProjeto.Controllers.Banda;

namespace PrimeiroProjeto.Controllers.Musica;

public class MusicaCLS {
	private readonly Exibir exibir = new Exibir();

	#region [Propriedades]
	public float Nota { get; }
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
		NomeMusica = nomeMusica;
		bandaInfo = banda;
		Compositores = compositores;
		Integrantes = integrantes;
		Patrocinadores = patrocinadores;
		ColaboradoresEspeciais = colaboradoresEspeciais;

		if(duracao >= 3600)
			Duracao = $"{TimeSpan.FromSeconds(duracao).Hours}h {TimeSpan.FromSeconds(duracao).Minutes}min {TimeSpan.FromSeconds(duracao).Minutes}s";
		else
			Duracao = $"{TimeSpan.FromSeconds(duracao).Minutes}min {TimeSpan.FromSeconds(duracao).Minutes}s";
	}
	#endregion

	#region [Métodos de Exibição]

	public void ExibirIntegrantes(List<Integrante> integrantes) {
		exibir.ExibirIntegrantes(integrantes);
	}
	public void ExibirCompositores(List<Compositor> compositores) {
		exibir.ExibirCompositores(compositores);
	}
	public void ExibirPatrocinadores(List<Patrocinadores> patrocinadores) {
		exibir.ExibirPatrocinadores(patrocinadores);
	}
	public void ExibirColaboradoresEspeciais(List<ColaboradorEspecial> colaboradoresEspeciais) {
		exibir.ExibirColaboradoresEspeciais(colaboradoresEspeciais);
	}

	#endregion

	public override string ToString() {
		return $"Nome: {NomeMusica}; Banda {bandaInfo.Nome}; Duração: {Duracao}; ";
	}
}
