using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;
public interface IGenericRepo<T> where T : BaseEntity
{
    Task<T> GetByIdAsync (int id);
    Task<IEnumerable<T>> GetAllAsync ();
    IEnumerable<T> Find (Expression<Func<T, bool>> expression);
    // Task<(int totalRegistros, IEnumerable<T> Registros)> GetAllAsync (int pageIndex, int pageSize, string searchString);
    void Add (T entity);
    void AddRange (IEnumerable<T> entities);
    void Remove (T entity);
    void RemoveRange (IEnumerable<T> entities);
    void Update (T entity);
}