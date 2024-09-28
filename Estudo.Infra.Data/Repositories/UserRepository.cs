using Estudo.Api.Infrastructure.Data;
using Estudo.Domain.Domain.Entities;
using Estudo.Domain.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Estudo.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            await _context.User.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(User entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.User.Where(_where => _where.Active).ToListAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await _context.User.FirstOrDefaultAsync(_find => _find.UserId == id);
        }

        public async Task<User> GetAsync(string login)
        {
            return await _context.User.FirstOrDefaultAsync(_find => _find.Login == login);
        }

        public async Task UpdateAsync(User entity)
        {
            _context.User.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}