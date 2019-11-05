using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorPeliculas.Shared.Entidades
{
  public class Pelicula
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Titulo { get; set; }
    public string Resumen { get; set; }
    public bool EnCartelera { get; set; }
    public string Trailer { get; set; }
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public DateTime? Lanzamiento { get; set; }
    public string Poster { get; set; }
    public List<GeneroPelicula> GeneroPelicula { get; set; } = new List<GeneroPelicula>();
    public List<PeliculaActor> PeliculaActor { get; set; }
    public string TituloCortado
    {
      get
      {
        if (string.IsNullOrWhiteSpace(Titulo)) return null;
        if (Titulo.Length > 60) return Titulo.Substring(0, 60) + "...";
        else return Titulo;
      }
    }
  }
}
