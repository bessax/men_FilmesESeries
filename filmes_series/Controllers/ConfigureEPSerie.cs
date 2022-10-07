using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using filmes_series.service.interfaces;
using filmes_series.Service.Request_response;

namespace series_series.startup;

public static class ConfigureEPSerie
{
    public static void AddEndpointsSerie(this WebApplication app)
    {
        #region serie

        app.MapGet("/v1/serie/todos", [Authorize] ([FromServices] ISerieAppService serieAppService) =>
        {
            return serieAppService.ObterTodosDTO();
        });
        app.MapPost("/v1/serie/add",  ([FromServices] ISerieAppService serieAppService, [FromBody] SerieRequest serieDTO) =>
        {
            return serieAppService.Adicionar(serieDTO);
        });
        app.MapPut("/v1/serie/upd/{id}",  ([FromServices] ISerieAppService serieAppService, [FromBody] SerieRequest serieDTO) =>
        {
            return serieAppService.Atualizar(serieDTO.Id, serieDTO);
        });
        app.MapGet("/v1/serie/{id}", ([FromServices] ISerieAppService serieAppService, [FromRoute] int id) =>
        {
            return serieAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/serie/del/{id}", ([FromServices] ISerieAppService serieAppService, [FromRoute] int id) =>
        {
            return serieAppService.ExcluirDTO(id);
        });

        #endregion

    }
}
