using Estudo.Api.Application.DTOs;
using Estudo.Api.Domain.Entities;
using System.Runtime.CompilerServices;

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

    public static Movie MapToUpdate(Movie movie, MovieDto movieDto)
    {
        movie.Adult = movieDto.Adult;
        movie.Overview = movieDto.Overview;
        movie.Popularity = movieDto.Popularity;
        movie.Title = movieDto.Title;
        movie.BackdropPath = movieDto.BackdropPath;
        movie.OriginalTitle = movieDto.OriginalTitle;
        movie.OriginalLanguage = movieDto.OriginalLanguage;
        movie.VoteAverage = movieDto.VoteAverage;
        movie.IdMovieApi = movieDto.IdMovieApi;
        movie.VoteCount = movieDto.VoteCount;
        return movie;
    }
}