using Estudo.Api.Application.Services;
using Estudo.Api.Domain.Repositories;
using Estudo.Api.Domain.Services;
using Estudo.Api.Infrastructure.Repositories;
using Estudo.Application.Application.Services;
using Estudo.Application.Interface;
using Estudo.Domain.Domain.Interfaces.HangFire;
using Estudo.Domain.Domain.Interfaces.Services;
using Estudo.Domain.Domain.Repositories;
using Estudo.Domain.Domain.Services;
using Estudo.Infra.Data.Repositories;
using Estudo.Infra.IoC.HangFireJobs;
using Microsoft.Extensions.DependencyInjection;

namespace Estudo.Infra.IoC.DependencyInjector;

public static class DependencyInjectorExtension
{
    public static IServiceCollection AddDependencyConfig(this IServiceCollection services)
    {
        services.AddScoped<IMovieRepository, MovieRepository>();
        services.AddScoped<IMovieAppService, MovieAppService>();
        services.AddScoped<IMovieService, MovieService>();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserAppService, UserAppService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IIntegrateMoviesJobs, IntegrateMoviesJobs>();

        return services;
    }
}