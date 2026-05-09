using CleanArchitectureCQRS.Domain.Entities;

namespace CleanArchitectureCQRS.Application.Interfaces
{
    public interface ICleanArchitectureCQRSRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);
        void DeleteAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task UpdadeAsync(T entity);
    }
}