namespace Estudo.Api.Application.DTOs;

public class MovieDto
{
    public Guid MovieId { get; set; }
    public bool Adult { get; set; }
    public string OriginalLanguage { get; set; }
    public string OriginalTitle { get; set; }
    public string Overview { get; set; }
    public decimal Popularity { get; set; }
    public string Title { get; set; }
    public int IdMovieApi { get; set; }
    public decimal VoteAverage { get; set; }
    public decimal VoteCount { get; set; }
    public string BackdropPath { get; set; }
}