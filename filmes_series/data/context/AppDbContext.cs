using filmes_series.domain.entity;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.context;

public class AppDbContext:DbContext
{    
    public DbSet<Ator>?Atores { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }

    public DbSet<Producao>? Producoes { get; set; }
    public DbSet<Filme>? Filmes { get; set; }
    public DbSet<Serie>? Series { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conexao = "Server=localhost;DataBase=catalogosFilmesSeries;Uid=root;Pwd=root";
        optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
    }
}
