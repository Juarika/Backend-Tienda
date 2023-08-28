namespace Core.Entities;

public class Persona : BaseEntity
{
    public string? NombrePersona { get; set; }
    public string? IdPersona { get; set; }
    public DateTime FechaNac { get; set; }
    public int IdTipoPer { get; set; }
    public TipoPersona? TipoPersona { get; set; }
    public int IdRegion { get; set; }
    public Region? Region { get; set; }
    public ICollection<Producto> Productos { get; set; } = new HashSet<Producto>();
    public ICollection<ProductoPersona>? ProductosPersona { get; set; }
}