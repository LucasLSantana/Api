using Estudo.Domain.Entities;

namespace Estudo.Domain.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> Get(int produtoId);
        Task CreateProdutoAsync(Produto produto);
    }
}