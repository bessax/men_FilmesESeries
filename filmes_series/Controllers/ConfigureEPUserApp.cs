using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPUserApp
{
    public static void AddEndpointsUserApp(this WebApplication app)
    {
        #region UserApp        
        app.MapGet("/v1/userApp/todos", ([FromServices] IUserAppAppService userAppAppService) =>
        {        
           return userAppAppService.ObterTodosDTO();
        });
        app.MapPost("/v1/userApp/add", ([FromServices] IUserAppAppService userAppAppService, [FromBody] UserAppRequest request) =>
        {
           return userAppAppService.Adicionar(request);
        });
      
        app.MapGet("/v1/userApp/{id}", ([FromServices] IUserAppAppService userAppAppService, [FromRoute] int id) =>
        {
            return userAppAppService.ObterPorIdDTO(id);
        });
       

        #endregion

    }
}
