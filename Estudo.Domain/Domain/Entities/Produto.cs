namespace Estudo.Api.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Descricao { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }
    }
}