using Estudo.Application.DTOs;
using Estudo.Domain.Entities;
using Estudo.Domain.Repositories;
using Estudo.Domain.Services;

namespace Estudo.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Produto> Get(int produtoId)
        {
            return await _repository.Get(produtoId);
        }

        public async Task CreateProdutoAsync(ProdutoDto produtoDto)
        {
            var produto = new Produto
            {
                Descricao = produtoDto.Descricao,
                Preco = produtoDto.Preco,
                Ativo = produtoDto.Ativo
            };

            await _repository.CreateProdutoAsync(produto);
        }
    }
}