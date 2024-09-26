using Estudo.Api.Application.DTOs;
using Estudo.Api.Domain.Entities;
using Estudo.Api.Domain.Services;
using Estudo.Application.Interface;

namespace Estudo.Api.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<ProdutoDto> Get(int produtoId)
        {
            var produto = await _produtoService.Get(produtoId);

            return new ProdutoDto()
            {
                Descricao = produto.Descricao,
                Preco = produto.Preco,
                Ativo = produto.Ativo,
            };
        }

        public async Task CreateProdutoAsync(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Descricao = produtoDto.Descricao,
                Preco = produtoDto.Preco,
                Ativo = produtoDto.Ativo,

            };
            await _produtoService.CreateProdutoAsync(produto);
        }
    }
}