using Estudo.Api.Domain.Services.Base;
using Estudo.Domain.Domain.Entities;

namespace Estudo.Domain.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        Task<User> GetAsync(string login);
    }
}