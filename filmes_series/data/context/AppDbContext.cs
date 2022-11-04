using filmes_series.domain.entity;
using filmes_series.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.context;

public class AppDbContext:DbContext
{
    private readonly ILoggerFactory _loggerFactory;
    public AppDbContext()
    {

    }
    public AppDbContext(ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory;
    }
    public DbSet<Ator>?Atores { get; set; }
    public DbSet<UserApp>? UserApps { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Filme>? Filmes {get; set;}
    public DbSet<Serie>? Series { get; set; }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // host.docker.internal para a aplicação no docker acessar o banco da máquina local.
        string conexao = "Server=host.docker.internal;DataBase=catalogosfilmesseries;Uid=root;Pwd=root";
        optionsBuilder.UseLazyLoadingProxies().UseMySql(conexao, ServerVersion.AutoDetect(conexao));
        optionsBuilder.UseLoggerFactory(_loggerFactory);
    }

   
}
