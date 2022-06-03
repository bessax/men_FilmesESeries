using filmes_series.startup;

var builder = WebApplication.CreateBuilder(args);

//DI
builder.Services.ConfigureDI();

//Mapper
builder.Services.AddAutoMapper(typeof(Program));

//Habilitando o swagger
builder.Services.AddEndpointsApiExplorer();

//Adicionando Endpoints
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

app.AddEndpoints();


app.UseSwaggerUI(
    c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoAPI V1");
        c.RoutePrefix = string.Empty;
    }
);

app.Run();
