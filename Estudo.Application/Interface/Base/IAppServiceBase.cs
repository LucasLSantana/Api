namespace Estudo.Application.Interface.Base;

public interface IAppServiceBase<T>
{
    Task<T> Get(Guid id);
    Task Add(T dto);
    Task Update(T dto);
    Task Delete(T dto);
    Task<List<T>> GetAll();
}