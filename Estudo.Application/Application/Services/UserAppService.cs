using Estudo.Application.Application.DTOs;
using Estudo.Application.Interface;
using Estudo.Application.Mappings;
using Estudo.Domain.Domain.Interfaces.Services;

namespace Estudo.Application.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task AddAsync(UserDto dto)
        {
            var user = UserMapping.MapToEntitie(dto);
            await _userService.AddAsync(user);
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _userService.GetAsync(id);
            await _userService.DeleteAsync(user);
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            var usersDto = new List<UserDto>();
            var users = await _userService.GetAllAsync();
            foreach (var user in users)
            {
                usersDto.Add(UserMapping.MapToDto(user));
            }
            return usersDto;
        }

        public async Task<UserDto> GetAsync(string login)
        {
            var user = await _userService.GetAsync(login);
            return UserMapping.MapToDto(user);
        }

        public async Task<UserDto> GetAsync(Guid id)
        {
            var user = await _userService.GetAsync(id);
            return UserMapping.MapToDto(user);
        }

        public async Task UpdateAsync(UserDto dto)
        {
            var user = await _userService.GetAsync(dto.Login);
            user = UserMapping.MapToUpdate(user, dto);
            await _userService.UpdateAsync(user);
        }
    }
}