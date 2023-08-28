using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Estado : BaseEntity
{
    public string? NombreEstado { get; set; }
    public int IdPais { get; set; }
    public Pais? Pais { get; set; }
    public ICollection<Region>? Regiones { get; set; }
}