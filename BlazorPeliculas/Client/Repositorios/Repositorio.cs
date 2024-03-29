﻿using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
  public class Repositorio : IRepositorio
  {
    private readonly HttpClient httpClient;

    public Repositorio(HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
    {
      var enviarJSON = JsonSerializer.Serialize(enviar);
      var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
      var responseHttp = await httpClient.PostAsync(url, enviarContent);

      return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
    }

    public List<Pelicula> ObtenerPeliculas()
    {
      return new List<Pelicula>
      {
        new Pelicula() { Titulo = "Spiderman - Lejos de casa",
                         Lanzamiento = new DateTime(2019, 6, 20),
                         Poster = "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg" },
        new Pelicula() { Titulo = "Vaiana", 
                         Lanzamiento = new DateTime(2017, 8, 12),
                         Poster = "https://m.media-amazon.com/images/M/MV5BMjI4MzU5NTExNF5BMl5BanBnXkFtZTgwNzY1MTEwMDI@._V1_UX182_CR0,0,182,268_AL_.jpg" },
        new Pelicula() { Titulo = "Origen", 
                         Lanzamiento = new DateTime(2010, 5, 15),
                         Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg" }
      };
    }
  }
}
