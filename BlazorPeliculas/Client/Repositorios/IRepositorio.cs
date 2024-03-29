﻿using BlazorPeliculas.Shared.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
  public interface IRepositorio
  {
    List<Pelicula> ObtenerPeliculas();
    Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
  }
}
