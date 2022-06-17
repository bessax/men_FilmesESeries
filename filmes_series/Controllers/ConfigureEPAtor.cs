using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPAtor
{
    public static void AddEndpointsAtor(this WebApplication app)
    {
        #region Ator        
        app.MapGet("/v1/ator/todos", ([FromServices] IAtorAppService atorAppService) =>
        {        
           return atorAppService.ObterTodosDTO();
        });
        app.MapPost("/v1/ator/add", ([FromServices] IAtorAppService atorAppService, [FromBody] AtorRequest atorDTO) =>
        {
           return atorAppService.Adicionar(atorDTO);
        });
        app.MapPut("/v1/ator/upd/{id}", ([FromServices]IAtorAppService atorAppService, [FromBody]AtorRequest atorDTO) =>
        {
            return atorAppService.Atualizar(atorDTO.Id, atorDTO);
        });
        app.MapGet("/v1/ator/{id}", ([FromServices] IAtorAppService atorAppService, [FromRoute] int id) =>
        {
            return atorAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/ator/del/{id}", ([FromServices] IAtorAppService atorAppService, [FromRoute] int id) =>
        {
            return atorAppService.ExcluirDTO(id);
        });
        #endregion
       
    }
}
