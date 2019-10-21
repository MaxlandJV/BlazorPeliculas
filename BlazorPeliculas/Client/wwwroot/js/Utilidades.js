function pruebaPuntoNetStatic() {
  DotNet.invokeMethodAsync("BlazorPeliculas.Client", "ObtenerCurrentCount")
    .then(resultado => {
      console.log(`Conteo desde Javascript ${resultado}`);
    });
}

function pruebaPuntoNETInstancia(dotnetHelper) {
  dotnetHelper.invokeMethodAsync("IncrementCount");
}