using filmes_series.mapper;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using filmes_series.startup;

var builder = WebApplication.CreateBuilder(args);

//DI
builder.Services.ConfigureDI();

//Mapper
builder.Services.AddAutoMapper(typeof(Program));

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

app.MapPost("/v1/ator/add", (IAtorAppService atorAppService,AtorRequest atorDTO) =>
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
