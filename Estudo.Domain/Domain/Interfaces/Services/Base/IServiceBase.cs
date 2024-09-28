namespace Estudo.Api.Domain.Services.Base;

public interface IServiceBase<T>
{
    Task<T> Get(Guid id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<List<T>> GetAll();
}