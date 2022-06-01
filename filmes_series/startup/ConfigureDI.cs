using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;
using filmes_series.domain.service;
using filmes_series.service.appService;
using filmes_series.service.interfaces;

namespace filmes_series.startup;

public static class ConfigureDIConfig
{
    public static void ConfigureDI(this IServiceCollection services)
    {
        ConfigureAppServices(services);
    }

    internal static void ConfigureAppServices(IServiceCollection services)
    {
        services.AddScoped<AppDbContext>();
        services.AddTransient<IAtorRepository, AtorRepository>();
        services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        services.AddTransient<IProducaoRepository, ProducoesRepository>();

        services.AddTransient<IAtorService, AtorService>();
        services.AddTransient<ICategoriaService, CategoriaService>();
        services.AddTransient<IProducaoService, ProducaoService>();

        services.AddTransient<IAtorAppService, AtorAppService>();
        services.AddTransient<ICategoriaAppService, CategoriaAppService>();
        services.AddTransient<IProducaoAppService, ProducaoAppService>();
    }
}
