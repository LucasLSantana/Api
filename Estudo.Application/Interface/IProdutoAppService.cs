using Estudo.Api.Application.DTOs;

namespace Estudo.Application.Interface;

public interface IProdutoAppService
{
    Task<ProdutoDto> Get(int produtoId);
    Task CreateProdutoAsync(ProdutoDto produtoDto);
}