using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using filmes_series.Service.Request_response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPFilme
{
    public static void AddEndpointsFilme(this WebApplication app)
    {
        #region filme

        app.MapGet("/v1/filme/todos", ([FromServices] IFilmeAppService filmeAppService) =>
        {
            return filmeAppService.ObterTodosDTO();
        });
        app.MapPost("/v1/filme/add",  ([FromServices] IFilmeAppService filmeAppService, [FromBody] FilmeRequest filmeDTO) =>
        {
            return filmeAppService.Adicionar(filmeDTO);
        });
        app.MapPut("/v1/filme/upd/{id}",  ([FromServices] IFilmeAppService filmeAppService, [FromBody] FilmeRequest filmeDTO) =>
        {
            return filmeAppService.Atualizar(filmeDTO.Id, filmeDTO);
        });
        app.MapGet("/v1/filme/{id}",  ([FromServices] IFilmeAppService filmeAppService, [FromRoute] int id) =>
        {
            return filmeAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/filme/del/{id}",  ([FromServices] IFilmeAppService filmeAppService, [FromRoute] int id) =>
        {
            return filmeAppService.ExcluirDTO(id);
        });

        #endregion

    }
}
