using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages
{
  public class CounterBase : ComponentBase
  {
    [Inject] protected ServicioSingleton Singleton { get; set; }
    [Inject] protected ServicioTransient Transient { get; set; }

    protected int currentCount = 0;

    protected void IncrementCount()
    {
      currentCount++;
      Singleton.Valor = currentCount;
      Transient.Valor = currentCount;
    }
  }
}
