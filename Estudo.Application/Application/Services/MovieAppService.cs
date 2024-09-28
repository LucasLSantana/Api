using Estudo.Api.Application.DTOs;
using Estudo.Api.Domain.Services;
using Estudo.Application.Interface;
using Estudo.Application.Mappings;

namespace Estudo.Api.Application.Services;
public class MovieAppService : IMovieAppService
{
    private readonly IMovieService _movieService;

    public MovieAppService(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public async Task<MovieDto> GetAsync(Guid id)
    {
      var movie = await _movieService.GetAsync(id);
      return MovieMapping.MapToDto(movie);
    }

    public async Task AddAsync(MovieDto dto)
    {
        var movie = MovieMapping.MapToEntitie(dto);
        await _movieService.AddAsync(movie);
    }

    public async Task UpdateAsync(MovieDto dto)
    {
        var movie = await _movieService.GetAsync(dto.MovieId);
        movie = MovieMapping.MapToUpdate(movie, dto);
        await _movieService.UpdateAsync(movie);
    }

    public async Task DeleteAsync(Guid id)
    {
        var movie = await _movieService.GetAsync(id);
        await _movieService.DeleteAsync(movie);
    }

    public async Task<List<MovieDto>> GetAllAsync()
    {
        var dtoList = new List<MovieDto>();
        var movies =  await _movieService.GetAllAsync();

        foreach (var movie in movies)        
        {
           dtoList.Add(MovieMapping.MapToDto(movie));
        }
        
        return dtoList;
    }
}