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

    public async Task<Movie> GetAsync(Guid id)
    {
        return await _movieRepository.GetAsync(id);
    }

    public async Task AddAsync(Movie entity)
    {
        await _movieRepository.AddAsync(entity);
    }

    public async Task UpdateAsync(Movie entity)
    {
        await _movieRepository.UpdateAsync(entity);
    }

    public async Task DeleteAsync(Movie entity)
    {
        if (entity is null) throw new Exception("Filme não encontrado");
        await _movieRepository.DeleteAsync(entity);
    }

    public async Task<List<Movie>> GetAllAsync()
    {
        return await _movieRepository.GetAllAsync();
    }
}