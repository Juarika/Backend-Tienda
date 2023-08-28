using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Producto : BaseEntity
{
    public string? CodInterno { get; set; }
    public string? Nombre { get; set; }
    public int StockMin { get; set; }
    public int StockMax { get; set; }
    public int Stock { get; set; }
    public decimal ValorVta { get; set; }
    public ICollection<Persona> Personas { get; set; } = new HashSet<Persona>();
    public ICollection<ProductoPersona>? ProductosPersona{ get; set; }
}