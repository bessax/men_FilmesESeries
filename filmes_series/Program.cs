using filmes_series;
using filmes_series.Security;
using filmes_series.startup;
using filmes_series.Startup;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//LogRequest
ConfigureLogRequest.AddSerialogAPI(builder);

//DI
builder.Services.ConfigureDI();

//Mapper
builder.Services.AddAutoMapper(typeof(Program));

//Habilitando o swagger
builder.Services.AddEndpointsApiExplorer();

//Token

var key = Encoding.ASCII.GetBytes(ConfigSeg.Secret);
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };

});



//Adicionando Endpoints
builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Filmes e Séries WEBAPI [Mentoria]", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                c.AddSecurityDefinition("bearer",
                                        new ApiKeyScheme
                                        {
                                            In = "header",
                                            Description = "Autenticação baseada em Json Web Token (JWT)",
                                            Name = "Authorization",
                                            Type = "apiKey"
                                        });
            });


var app = builder.Build();

app.UseSwagger();

//Endpoints
app.AddEndpointsUserApp();
app.AddEndpointsAuth();
app.AddEndpointsAtor();
app.AddEndpointsCategoria();
app.AddEndpointsProducao();
app.AddEndpointsAtorProducao();

app.UseSwaggerUI(
    c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoAPI V1");
        c.RoutePrefix = string.Empty;
    }
);

app.UseCors(op => op.AllowAnyOrigin().AllowAnyMethod().AllowAnyMethod());
app.UseAuthentication();
app.UseAuthorization();
//app.Use(async (context, next) =>
//{
//    var JWToken = context.Session.GetString("JWToken");
//    if (!string.IsNullOrEmpty(JWToken))
//    {
//        context.Request.Headers.Add("Authorization", "Bearer " + JWToken);
//    }
//    await next();
//});

app.Run();
