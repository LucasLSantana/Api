using Estudo.Application.Application.DTOs;
using Estudo.Application.Interface.Base;

namespace Estudo.Application.Interface
{
    public interface IUserAppService : IAppServiceBase<UserDto>
    {
        Task<UserDto> GetAsync(string login);
    }
}