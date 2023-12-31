using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class TipoPersona : BaseEntity
{
    public string? Descripcion { get; set; }
    public ICollection<Persona>? Personas { get; set; }
}