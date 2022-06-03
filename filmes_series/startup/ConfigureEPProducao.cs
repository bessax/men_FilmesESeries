using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPProducao
{
    public static void AddEndpointsProducao(this WebApplication app)
    {
   
        #region Produções
        string producao = "producao";
        app.MapGet($"/v1/{producao}/todos", ([FromServices] IProducaoAppService producaoAppService) =>
        {
            return producaoAppService.ObterTodosDTO();
        });
        app.MapPost($"/v1/{producao}/add", ([FromServices] IProducaoAppService producaoAppService, [FromBody] ProducaoRequest obj) =>
        {
            return producaoAppService.Adicionar(obj);
        });
        app.MapPut($"/v1/{producao}/upd", ([FromServices] IProducaoAppService producaoAppService, [FromBody] ProducaoRequest obj) =>
        {
            return producaoAppService.Atualizar(obj.Id, obj);
        });
        app.MapGet("/v1/producao/{id}", ([FromServices] IProducaoAppService producaoAppService, [FromRoute] int id) =>
        {
            return producaoAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/producao/del/{id}", ([FromServices] IProducaoAppService producaoAppService, [FromRoute] int id) =>
        {
            return producaoAppService.ExcluirDTO(id);
        });
        #endregion

    
    }
}
