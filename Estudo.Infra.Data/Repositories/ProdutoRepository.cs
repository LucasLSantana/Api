using Estudo.Api.Domain.Entities;
using Estudo.Api.Domain.Repositories;
using Estudo.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Estudo.Api.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> Get(int produtoId)
        {
            return await _context.Produto.FirstOrDefaultAsync(predicate => predicate.ProdutoId == produtoId);
        }

        public async Task CreateProdutoAsync(Produto produto)
        {
            await _context.Produto.AddAsync(produto);
            await _context.SaveChangesAsync();
        }
    }
}