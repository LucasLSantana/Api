using Estudo.Api.Application.DTOs;
using Estudo.Api.Domain.Entities;

namespace Estudo.Application.Mappings;

public class MovieMapping
{
    public static Movie MapToEntitie(MovieDto movieDto)
    {
        return new Movie()
        {
            MovieId = movieDto.MovieId,
            Adult = movieDto.Adult,
            Overview = movieDto.Overview,
            Popularity = movieDto.Popularity,
            Title = movieDto.Title,
            BackdropPath = movieDto.BackdropPath,
            OriginalTitle = movieDto.OriginalTitle,
            OriginalLanguage = movieDto.OriginalLanguage,
            VoteAverage = movieDto.VoteAverage,
            IdMovieApi = movieDto.IdMovieApi,
            VoteCount = movieDto.VoteCount,
        };
    }
    
    public static MovieDto MapToDto(Movie movie)
    {
        return new MovieDto()
        {
            MovieId = movie.MovieId,
            Adult = movie.Adult,
            Overview = movie.Overview,
            Popularity = movie.Popularity,
            Title = movie.Title,
            BackdropPath = movie.BackdropPath,
            OriginalTitle = movie.OriginalTitle,
            OriginalLanguage = movie.OriginalLanguage,
            VoteAverage = movie.VoteAverage,
            IdMovieApi = movie.IdMovieApi,
            VoteCount = movie.VoteCount,
        };
    }
    
}