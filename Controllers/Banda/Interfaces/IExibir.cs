﻿namespace PrimeiroProjeto.Controllers;
public interface IExibir {
    public void Albuns(List<Album> albuns, string nome);
    public void Musicas(List<Musica> musicas, string nome);
    public void Integrantes(List<Integrante> integrantes, string nome);

    //public void AdicionarAlbum(Album album) { Albuns.Add(album); }
    //public void AdicionarMusica(Musica musico) { Musicas.Add(musico); }
    //public void AdicionarIntegrante(Integrante integrante) { Integrantes.Add(integrante); }

}
