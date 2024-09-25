using Estudo.Application.DTOs;
using Estudo.Domain.Entities;

namespace Estudo.Domain.Services
{
    public interface IProdutoService
    {
        Task<Produto> Get(int produtoId);
        Task CreateProdutoAsync(ProdutoDto produtoDto);
    }
}