using Estudo.Api.Application.DTOs;
using Estudo.Api.Domain.Entities;
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

    public async Task<MovieDto> Get(Guid id)
    {
      var movie = await _movieService.Get(id);
      return MovieMapping.MapToDto(movie);
    }

    public async Task Add(MovieDto dto)
    {
        var movie = MovieMapping.MapToEntitie(dto);
        await _movieService.Add(movie);
    }

    public async Task Update(MovieDto dto)
    { 
        var movie = MovieMapping.MapToEntitie(dto);
        await _movieService.Update(movie);
    }

    public async Task Delete(MovieDto dto)
    {
        var movie = MovieMapping.MapToEntitie(dto);
        await _movieService.Delete(movie);
    }

    public async Task<List<MovieDto>> GetAll()
    {
        var dtoList = new List<MovieDto>();
        var movies =  await _movieService.GetAll();

        foreach (var movie in movies)        
        {
           dtoList.Add(MovieMapping.MapToDto(movie));
        }
        
        return dtoList;
    }
}