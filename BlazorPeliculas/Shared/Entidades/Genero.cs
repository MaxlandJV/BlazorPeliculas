using System.ComponentModel.DataAnnotations;

namespace BlazorPeliculas.Shared.Entidades
{
  public class Genero
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Nombre { get; set; }
  }
}
