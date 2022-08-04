using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.Data.Repository;
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
        services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
        services.AddTransient<IAtorRepository, AtorRepository>();
        services.AddTransient<ICategoriaRepository, CategoriaRepository>();
        services.AddTransient<IProducaoRepository, ProducoesRepository>();
        services.AddTransient<IAtorProducaoRepository, AtorProducaoRepository>();
        services.AddTransient<IUserAppRepository, UserAppRepository>();
        
        services.AddTransient<IAtorService, AtorService>();
        services.AddTransient<ICategoriaService, CategoriaService>();
        services.AddTransient<IProducaoService, ProducaoService>();        
        services.AddTransient<IAtorProducaoService, AtorProducaoService>();
        services.AddTransient<IUserAppService, UserAppService>();

        services.AddTransient<IAtorAppService, AtorAppService>();
        services.AddTransient<ICategoriaAppService, CategoriaAppService>();
        services.AddTransient<IProducaoAppService, ProducaoAppService>();
        services.AddTransient<IAtorProducaoAppService, AtorProducaoAppService>();
        services.AddTransient<IUserAppAppService, UserAppAppService>();
    }

   
}
