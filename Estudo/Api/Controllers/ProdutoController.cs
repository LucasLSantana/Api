using Estudo.Application.DTOs;
using Estudo.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Estudo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet] 
        public async Task<ActionResult> Get(int produtoId)
        {
            var produto = await _service.Get(produtoId);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult> Create(ProdutoDto produtoDto)
        {
            await _service.CreateProdutoAsync(produtoDto);
            return CreatedAtAction(nameof(Get), produtoDto);
        }
    }
}