namespace Core.Interfaces;

public interface IUnitOfWork
{
    IPais Paises { get; }
    IRegion Regiones { get; }
    IEstado Estados { get; }
    Task<int> SaveAsync();
}