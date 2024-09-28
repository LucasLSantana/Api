using Estudo.Api.Application.DTOs;
using Estudo.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Estudo.Api.Controllers;

public class MovieController : ControllerBase
{
    private readonly IMovieAppService _movieAppService;
    public MovieController(IMovieAppService movieAppService)
    {
        _movieAppService = movieAppService;
    }

    [HttpGet]
    [Route("get-movie")]
    public async Task<ActionResult<MovieDto>> GetAsync(Guid movieId)
    {
        try
        {
            var movie = await _movieAppService.GetAsync(movieId);
            return Ok(movie);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet]
    [Route("get-all-movie")]
    public async Task<ActionResult<List<MovieDto>>> GetAllAsync()
    {
        try
        {
            var movies = await _movieAppService.GetAllAsync();
            return Ok(movies);
        }
        catch
        {
            return BadRequest();
        }
    }
}