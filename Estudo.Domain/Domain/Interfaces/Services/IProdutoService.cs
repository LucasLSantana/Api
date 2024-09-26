
using Estudo.Api.Domain.Entities;

namespace Estudo.Api.Domain.Services
{
    public interface IProdutoService
    {
        Task<Produto> Get(int produtoId);
        Task CreateProdutoAsync(Produto produtoDto);
    }
}