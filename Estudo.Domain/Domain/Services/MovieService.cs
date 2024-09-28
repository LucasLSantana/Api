using Estudo.Api.Domain.Entities;
using Estudo.Api.Domain.Repositories;
using Estudo.Api.Domain.Services;
using Estudo.Api.Domain.Services.Base;

namespace Estudo.Domain.Domain.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<Movie> Get(Guid id)
    {
        return await _movieRepository.Get(id);
    }

    public async Task Add(Movie entity)
    {
        await _movieRepository.Add(entity);
    }

    public async Task Update(Movie entity)
    {
        await _movieRepository.Update(entity);
    }

    public async Task Delete(Movie entity)
    {
        await _movieRepository.Delete(entity);
    }

    public async Task<List<Movie>> GetAll()
    {
        return await _movieRepository.GetAll();
    }
}