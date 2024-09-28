namespace Estudo.Api.Domain.Services.Base;

public interface IServiceBase<T>
{
    Task<T> GetAsync(Guid id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<List<T>> GetAllAsync();
}