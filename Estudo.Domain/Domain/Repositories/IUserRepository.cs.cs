using Estudo.Api.Infrastructure.Repositories.Base;
using Estudo.Domain.Domain.Entities;

namespace Estudo.Domain.Domain.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> GetAsync(string login);
    }
}