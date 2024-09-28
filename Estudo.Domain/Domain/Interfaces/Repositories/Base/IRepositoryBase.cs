namespace Estudo.Api.Infrastructure.Repositories.Base;

public interface IRepositoryBase<T>
{
    Task<T> GetAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<List<T>> GetAllAsync();
}