﻿using filmes_series.domain.entity;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.context;

public class AppDbContext:DbContext
{    
    public DbSet<Ator>?Atores { get; set; }
    public DbSet<Categoria>? Categorias { get; set; }
    public DbSet<Producao>? Producoes { get; set; }
    public DbSet<Filme>? Filme { get; set; }
    public DbSet<Serie>? Serie { get; set; }  
    public DbSet<AtorProducao>? AtorProducao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conexao = "Server=localhost;DataBase=catalogosFilmesSeries;Uid=root;Pwd=root";
        optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
    }
    
}
