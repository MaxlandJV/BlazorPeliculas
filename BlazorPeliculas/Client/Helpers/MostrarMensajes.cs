﻿using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
  public class MostrarMensajes : IMostrarMensajes
  {
    public async Task MostrarMensajeError(string mensaje)
    {
      await Task.FromResult(0);
    }
  }
}
