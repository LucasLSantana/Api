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

    public async Task<Movie> Get(Guid id)
    {
        return await _context.Movie.FirstOrDefaultAsync(a => a.MovieId == id);
    }

    public async Task Add(Movie entity)
    {
        await _context.Movie.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Movie entity)
    { 
        _context.Movie.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Movie entity)
    {
       _context.Movie.Remove(entity);
       await _context.SaveChangesAsync();
    }

    public async Task<List<Movie>> GetAll()
    {
        return await _context.Movie.Where(a=>a.Active).ToListAsync();
    }
}