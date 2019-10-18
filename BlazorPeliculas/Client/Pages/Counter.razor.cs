using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Pages
{
  public class CounterBase : ComponentBase
  {
    [Inject] protected ServicioSingleton Singleton { get; set; }
    [Inject] protected ServicioTransient Transient { get; set; }
    [Inject] protected IJSRuntime JS { get; set; }

    protected int currentCount = 0;
    static int currentCountStatic = 0;

    protected async Task IncrementCount()
    {
      currentCount++;
      Singleton.Valor = currentCount;
      Transient.Valor = currentCount;
      currentCountStatic++;
      await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
    }

    [JSInvokable]
    public static Task<int> ObtenerCurrentCount()
    {
      return Task.FromResult(currentCountStatic);
    }
  }
}
