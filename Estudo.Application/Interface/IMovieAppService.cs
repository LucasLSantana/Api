using Estudo.Api.Application.DTOs;
using Estudo.Api.Domain.Entities;
using Estudo.Application.Interface.Base;

namespace Estudo.Application.Interface;

public interface IMovieAppService : IAppServiceBase<MovieDto>
{
    
}