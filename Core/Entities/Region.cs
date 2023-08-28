using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Region : BaseEntity
{
    public string? NombreRegion { get; set; }
    public int IdEstado { get; set; }
    public Estado? Estado{ get; set; }
    public ICollection<Persona>? Personas { get; set; }

}