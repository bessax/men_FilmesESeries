using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;
using filmes_series.domain.service;
using filmes_series.service.appService;
using filmes_series.service.dto;
using filmes_series.service.interfaces;
using filmes_series.startup;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//DI
builder.Services.ConfigureDI();

//Habilitando o swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



app.UseSwagger();

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

app.UseSwaggerUI(
    c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoAPI V1");
        c.RoutePrefix = string.Empty;
    }
);

app.Run();
