using System.Diagnostics;
using Estudo.Domain.Domain.Interfaces.HangFire;
using Estudo.Infra.IoC.HangFireJobs;
using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Estudo.Infra.IoC.DependencyInjector;

public static class HangFireExtension
{
    public static IServiceCollection AddHangFireConfig(this IServiceCollection services, IConfiguration configuration)
    {
        var config = configuration.GetConnectionString("DefaultConnection");
        services.AddHangfire(configuration => configuration
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UseSqlServerStorage(config));

        services.AddHangfireServer(options =>
        {
            options.Queues = new[] { "default" };
            options.WorkerCount = 3;
            options.ServerName = "default";
            options.TimeZoneResolver = new DefaultTimeZoneResolver();
        });
        services.AddHangfireServer(options =>
        {
            options.Queues = new[] { "critical" };
            options.WorkerCount = 3;
            options.ServerName = "critical";
            options.TimeZoneResolver = new DefaultTimeZoneResolver();
        });
        
        //StartJobs();
        return services;
    }
    public static void StartJobs()
    {
        RecurringJob.AddOrUpdate<IIntegrateMoviesJobs>("Integrate Movies", x => x.IntegrateMovies(1) , Cron.Daily, TimeZoneInfo.Utc);
    }
}