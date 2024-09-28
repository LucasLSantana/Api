namespace Estudo.Api.Domain.Entities.Base;

public interface IEntitiesBase
{
    DateTime CreateDate { get; set; }
    DateTime? UpdateDate { get; set; }
    bool Active { get; set; }
}