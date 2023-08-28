using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class RegionRepository : GenericRepository<Region>, IRegion
{
    private readonly TiendaContext _context;
    public RegionRepository(TiendaContext context) : base(context)
    {
        _context = context;
    }

    public override void Add(Region Region)
    {
        _context.Set<Region>().Add(Region);
    }

    public override void AddRange(IEnumerable<Region> Region)
    {
        _context.Set<Region>().AddRange(Region);
    }

    public override IEnumerable<Region> Find(Expression<Func<Region, bool>> expression)
    {
        return _context.Set<Region>().Where(expression);
    }

    public override async Task<IEnumerable<Region>> GetAllAsync()
    {
        return await _context.Regiones
            .Include(p => p.Personas)
            .ToListAsync();
    }

    public override async Task<Region> GetByIdAsync(int id)
    {
        return await _context.Regiones
            .Include(p => p.Personas)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    //  public override void Remove(Region entity)
    // {
    //     _context.Set<Region>().Remove(entity);
    // }

    // public override void RemoveRange(IEnumerable<Region> Region)
    // {
    //     _context.Set<Region>().RemoveRange(Region);
    // }

    public override void Update(Region entity)
    {
        _context.Set<Region>()
            .Update(entity);
    }
}