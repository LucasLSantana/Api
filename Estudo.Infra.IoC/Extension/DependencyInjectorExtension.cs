using Estudo.Api.Application.Services;
using Estudo.Api.Domain.Repositories;
using Estudo.Api.Domain.Services;
using Estudo.Api.Infrastructure.Repositories;
using Estudo.Application.Interface;
using Estudo.Domain.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Estudo.Infra.IoC.DependencyInjector;

public static class DependencyInjectorExtension
{
    public static IServiceCollection AddDependencyConfig(this IServiceCollection services)
    {
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoAppService, ProdutoAppService>();
        services.AddScoped<IProdutoService, ProdutoService>();

        return services;
    }
}