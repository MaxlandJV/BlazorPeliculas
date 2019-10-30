using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorPeliculas.Shared.Entidades
{
  public class Persona
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public string Nombre { get; set; }
    public string Biografia { get; set; }
    public string Foto { get; set; }
    [Required(ErrorMessage = "El campo {0} es obligatorio")]
    public DateTime? FechaNacimiento { get; set; }
  }
}
