using Estudo.Api.Domain.Entities;

namespace Estudo.Api.Domain.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> Get(int produtoId);
        Task CreateProdutoAsync(Produto produto);
    }
}