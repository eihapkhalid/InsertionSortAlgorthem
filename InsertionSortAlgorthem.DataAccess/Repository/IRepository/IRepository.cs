using System.Linq.Expressions;

namespace InsertionSortAlgorthem.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Table Name
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        void AddRange(IEnumerable<T> entities);
    }
}
