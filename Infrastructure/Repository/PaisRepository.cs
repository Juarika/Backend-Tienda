using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly TiendaContext _context;
    public PaisRepository(TiendaContext context) : base(context)
    {
        _context = context;
    }

    public override void Add(Pais pais)
    {
        _context.Set<Pais>().Add(pais);
    }

    public override void AddRange(IEnumerable<Pais> pais)
    {
        _context.Set<Pais>().AddRange(pais);
    }

    public override IEnumerable<Pais> Find(Expression<Func<Pais, bool>> expression)
    {
        return _context.Set<Pais>().Where(expression);
    }

    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .ToListAsync();
    }

    public override async Task<Pais> GetByIdAsync(int id)
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    //  public override void Remove(Pais entity)
    // {
    //     _context.Set<Pais>().Remove(entity);
    // }

    // public override void RemoveRange(IEnumerable<Pais> pais)
    // {
    //     _context.Set<Pais>().RemoveRange(pais);
    // }

    public override void Update(Pais entity)
    {
        _context.Set<Pais>()
            .Update(entity);
    }
}