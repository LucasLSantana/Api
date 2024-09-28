namespace Estudo.Application.Interface.Base;

public interface IAppServiceBase<T>
{
    Task<T> GetAsync(Guid id);
    Task AddAsync(T dto);
    Task UpdateAsync(T dto);
    Task DeleteAsync(Guid id);
    Task<List<T>> GetAllAsync();
}