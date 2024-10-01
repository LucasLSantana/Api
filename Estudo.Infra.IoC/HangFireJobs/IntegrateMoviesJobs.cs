using Estudo.Api.Domain.Entities;
using Estudo.Api.Domain.Repositories;
using Estudo.Domain.Domain.Interfaces.HangFire;
using Newtonsoft.Json;
using RestSharp;

namespace Estudo.Infra.IoC.HangFireJobs;

public class IntegrateMoviesJobs : IIntegrateMoviesJobs
{
    private readonly IMovieRepository _movieRepository;

    public IntegrateMoviesJobs(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async void IntegrateMovies(int page)
    {
        var contents = new List<Content>();
        while (page <= 50)
        {
            var options =
                new RestClientOptions($"https://api.themoviedb.org/3/movie/popular?language=en-US&page={page}");
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization",
                "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJmZmE1YjcwMjMwNTI4YjE2ODU2Y2QyOWE5MjkwYjkzOCIsIm5iZiI6MTcyNzc0MDc5MS40NTc3NTEsInN1YiI6IjYzZWVhMzQ3N2YxZDgzMDA4NTJhZDgxMCIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.1QscupukA9nghGB-MHfxqCyLCSUa_Vs55Ro9pMuHb3k");
            var response = await client.GetAsync(request);

            var responseClass = JsonConvert.DeserializeObject<Response>(response.Content);
            contents.AddRange(responseClass.Results);
            page++;
        }

        var movies = new List<Movie>();
        var moviesBase = new List<Movie>();
        try
        {
            moviesBase = await _movieRepository.GetAllAsync();
        }
        catch (Exception ex)
        {
            var tesste = ex.Message;
        }

        contents.AsParallel().ForAll(a =>
        {
            if (moviesBase.Exists(e => e.IdMovieApi == a.Id))
            {
                var movieBase = moviesBase.FirstOrDefault(f => f.IdMovieApi == a.Id);
                movieBase.Adult = a.Adult;
                movieBase.Overview = a.Overview;
                movieBase.Popularity = a.Popularity;
                movieBase.Title = a.Title;
                movieBase.Active = true;
                movieBase.BackdropPath = a.Backdrop_path;
                movieBase.UpdateDate = DateTime.Now;
                movieBase.OriginalLanguage = a.Original_language;
                movieBase.OriginalTitle = a.Original_title;
                movieBase.VoteAverage = a.Vote_average;
                movieBase.VoteCount = a.Vote_count;
            }
            else
            {
                movies.Add(new Movie()
                {
                    Adult = a.Adult,
                    Overview = a.Overview,
                    Popularity = a.Popularity,
                    Title = a.Title,
                    Active = true,
                    BackdropPath = a.Backdrop_path,
                    CreateDate = DateTime.Now,
                    IdMovieApi = a.Id,
                    OriginalLanguage = a.Original_language,
                    OriginalTitle = a.Original_title,
                    VoteAverage = a.Vote_average,
                    VoteCount = a.Vote_count,
                });
            }
        });
        await _movieRepository.AddRangeAsync(movies);
    }

    public class Response
    {
        public int Page { get; set; }
        public List<Content> Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }

    public class Content
    {
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; }
        public List<int> Genre_ids { get; set; }
        public int Id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public decimal Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public decimal Vote_average { get; set; }
        public int Vote_count { get; set; }
    }
}