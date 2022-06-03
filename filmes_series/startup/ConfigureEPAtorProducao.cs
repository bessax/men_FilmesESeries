using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPAtorProducao
{
    public static void AddEndpointsAtorProducao(this WebApplication app)
    {
        #region Ator-Producao
        string ator_producao = "ator-producao";
        app.MapGet($"/v1/{ator_producao}/todos", ([FromServices] IAtorProducaoAppService atorproducaoAppService) =>
        {
            return atorproducaoAppService.ObterTodosDTO();
        });
        app.MapPost($"/v1/{ator_producao}/add", ([FromServices] IAtorProducaoAppService atorproducaoAppService, [FromBody] AtorProducaoRequest obj) =>
        {
            return atorproducaoAppService.Adicionar(obj);
        });
        //app.MapPut($"/v1/{ator_producao}/upd", ([FromServices] IAtorProducaoAppService atorproducaoAppService, [FromBody] AtorProducaoRequest obj) =>
        //{
        //    return atorproducaoAppService.Atualizar(obj.Id, obj);
        //});
        app.MapGet("/v1/ator-producao/{id}", ([FromServices] IAtorProducaoAppService atorproducaoAppService, [FromRoute] int id) =>
        {
            return atorproducaoAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/ator-producao/del/{id}", ([FromServices] IAtorProducaoAppService atorproducaoAppService, [FromRoute] int id) =>
        {
            return atorproducaoAppService.ExcluirDTO(id);
        });
        #endregion
    }
}
