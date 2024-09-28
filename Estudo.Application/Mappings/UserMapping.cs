using Estudo.Application.Application.DTOs;
using Estudo.Domain.Domain.Entities;

namespace Estudo.Application.Mappings
{
    public class UserMapping
    {
        public static User MapToEntitie(UserDto userDto)
        {
            return new User
            {
                Name = userDto.Name,
                Login = userDto.Login,
                LastName = userDto.LastName,
                Email = userDto.Email,
                City = userDto.City,
                ZipCode = userDto.ZipCode,
                State = userDto.State,
                Country = userDto.Country,
                Phone = userDto.Phone,
                Password = userDto.Password,
                Active = userDto.Active,
            };
        }

        public static UserDto MapToDto (User user)
        {
            return new UserDto
            {
                Name = user.Name,
                LastName = user.LastName,
                Login = user.Login,
                Email = user.Email,
                City = user.City,
                ZipCode = user.ZipCode,
                State = user.State,
                Country = user.Country,
                Phone = user.Phone,
                Password = user.Password,
                Active = user.Active,
            };
        }

        public static User MapToUpdate(User user, UserDto userDto)
        {
            user.Name = userDto.Name;
            user.LastName = userDto.LastName;
            user.Email = userDto.Email;
            user.City = userDto.City;
            user.ZipCode = userDto.ZipCode;
            user.State = userDto.State;
            user.Country = userDto.Country;
            user.Phone = userDto.Phone;
            user.Password = userDto.Password;
            user.Active = userDto.Active;
            user.UpdateDate = DateTime.Now;
            return user;
        }
    }
}
