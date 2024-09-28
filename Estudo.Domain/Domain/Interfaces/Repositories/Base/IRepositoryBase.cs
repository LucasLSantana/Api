namespace Estudo.Api.Infrastructure.Repositories.Base;

public interface IRepositoryBase<T>
{
    Task<T> Get(Guid id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<List<T>> GetAll();
}