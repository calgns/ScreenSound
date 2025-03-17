namespace PrimeiroProjeto.Controllers;

public class Musica {
    public string Nome { get; }
    public int Duracao { get; }
    public List<Compositor> Compositores { get; }
    public List<Integrante> Integrantes { get; }
    public List<Patrocinadores>? Patrocinadores { get; }
    public List<ColaboradorEspecial>? ColaboradoresEspeciais { get; }

    public Musica(
        string nome, 
        int duracao, 
        List<Compositor> compositores, 
        List<Integrante> integrantes, 
        List<Patrocinadores>? patrocinadores = null, 
        List<ColaboradorEspecial>? colaboradoresEspeciais = null)
    {
        Nome = nome;
        Duracao = duracao;
        Compositores = compositores;
        Integrantes = integrantes;
        Patrocinadores = patrocinadores;
        ColaboradoresEspeciais = colaboradoresEspeciais;
    }
}
