using Estudo.Api.Domain.Entities;
using Estudo.Api.Infrastructure.Repositories.Base;

namespace Estudo.Api.Domain.Repositories;

public interface IMovieRepository : IRepositoryBase<Movie>
{
    Task AddRangeAsync(List<Movie> movies);
    Task UpdateRangeAsync(List<Movie> movies);
}