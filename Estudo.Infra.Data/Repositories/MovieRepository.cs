using Estudo.Api.Domain.Entities;
using Estudo.Api.Domain.Repositories;
using Estudo.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Estudo.Api.Infrastructure.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly ApplicationDbContext _context;

    public MovieRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Movie> GetAsync(Guid id)
    {
        return await _context.Movie.FirstOrDefaultAsync(a => a.MovieId == id);
    }

    public async Task AddAsync(Movie entity)
    {
        await _context.Movie.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Movie entity)
    {
        _context.Movie.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Movie entity)
    {
        _context.Movie.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Movie>> GetAllAsync()
    {
        return await _context.Movie.Where(a => a.Active).ToListAsync();
    }

    public async Task AddRangeAsync(List<Movie> movies)
    {
        await _context.Movie.AddRangeAsync(movies);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRangeAsync(List<Movie> movies)
    {
        await _context.SaveChangesAsync();
    }
}