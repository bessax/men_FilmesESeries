using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;
using filmes_series.domain.service;
using filmes_series.service.appService;
using filmes_series.service.dto;
using filmes_series.service.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Conexão
//string connection = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddTransient<IAtorRepository, AtorRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IProducaoRepository, ProducoesRepository>();

builder.Services.AddTransient<IAtorService, AtorService>();
builder.Services.AddTransient<ICategoriaService, CategoriaService>();
builder.Services.AddTransient<IProducaoService, ProducaoService>();

builder.Services.AddTransient<IAtorAppService, AtorAppService>();
builder.Services.AddTransient<ICategoriaAppService, CategoriaAppService>();
builder.Services.AddTransient<IProducaoAppService, ProducaoAppService>();


//Habilitando o swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();


// Endpoints da solução
app.MapGet("/", () => "Hello World!");

//// Listar Atores.
app.MapGet("/v1/ator/todos", (IAtorAppService atorAppService) =>
{
    return atorAppService.ObterTodosDTO();
});

app.MapPost("/v1/ator/add", (IAtorAppService atorAppService,AtorDTO atorDTO) =>
{
    return atorAppService.Adicionar(atorDTO);
});

app.UseSwaggerUI();
app.Run();
