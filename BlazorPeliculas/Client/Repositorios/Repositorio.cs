using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;

namespace BlazorPeliculas.Client.Repositorios
{
  public class Repositorio : IRepositorio
  {
    public List<Pelicula> ObtenerPeliculas()
    {
      return new List<Pelicula>
      {
        new Pelicula() { Titulo = "Spiderman - Lejos de casa", Lanzamiento = new DateTime(2019, 6, 20) },
        new Pelicula() { Titulo = "Vaiana", Lanzamiento = new DateTime(2017, 8, 12) },
        new Pelicula() { Titulo = "Origen", Lanzamiento = new DateTime(2010, 5, 15) }
      };
    }
  }
}
