namespace PrimeiroProjeto.Controllers.Musica;

public class Exibir : IExibir {

	public void ExibirIntegrantes(List<Integrante> integrantes) {
		ExibirLista("Integrante", "Integrantes", integrantes.Cast<object>().ToList());
	}
	public void ExibirCompositores(List<Compositor> compositores) {
		ExibirLista("Compositor", "Compositores", compositores.Cast<object>().ToList());
	}
	public void ExibirPatrocinadores(List<Patrocinadores>? patrocinadores) {
		ExibirLista("Patrocinador", "Patrocinadores", patrocinadores?.Cast<object>().ToList());
	}
	public void ExibirColaboradoresEspeciais(List<ColaboradorEspecial>? colaboradoresEspeciais) {
		ExibirLista("Colaborador Especial", "Colaboradores Especiais", colaboradoresEspeciais?.Cast<object>().ToList());
	}

	public void ExibirLista(string singular, string plural, List<object>? lista) {
		if (lista == null)
			Console.WriteLine($"Nenhum {singular} encontrado.");

		else if(lista.Count == 1)
			Console.WriteLine($"{singular}: {lista[0].GetType().GetProperty("Nome")}");

		else if (lista.Count > 1) {
			Console.WriteLine($"{plural}: ");
			for (int i = 0; i < lista.Count; i++)
				Console.WriteLine($"  {i} - {singular}: {lista[i].GetType().GetProperty("Nome")}");
		}
	}

}
