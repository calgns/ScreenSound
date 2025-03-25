namespace PrimeiroProjeto.Controllers.Musica;

interface IExibir {

	public void ExibirIntegrantes(List<Integrante> integrantes);
	public void ExibirCompositores(List<Compositor> compositores);
	public void ExibirPatrocinadores(List<Patrocinadores>? patrocinadores);
	public void ExibirColaboradoresEspeciais(List<ColaboradorEspecial>? colaboradoresEspeciais);

	public void ExibirLista(string singular, string plural, List<object>? lista);

}
