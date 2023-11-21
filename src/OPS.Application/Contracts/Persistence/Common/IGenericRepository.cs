using OPS.Domain.Common;

namespace OPS.Application.Contracts.Persistence.Common
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task UpdateAsync(T entity);
    }
}