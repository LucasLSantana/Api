using Estudo.Api.Domain.Entities;
using Estudo.Api.Domain.Repositories;
using Estudo.Api.Domain.Services;

namespace Estudo.Domain.Domain.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<Produto> Get(int produtoId)
    {
      return await _produtoRepository.Get(produtoId);
    }

    public async Task CreateProdutoAsync(Produto produto)
    {
        await _produtoRepository.CreateProdutoAsync(produto);
    }
}