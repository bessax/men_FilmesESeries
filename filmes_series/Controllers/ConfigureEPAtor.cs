using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPAtor
{
    public static void AddEndpointsAtor(this WebApplication app)
    {
        #region Ator
        
        app.MapGet("/v1/ator/todos",  ([FromServices] IAtorAppService atorAppService) =>
        {        
           return atorAppService.ObterTodosDTO();
        });
        app.MapPost("/v1/ator/add", ([FromServices] IAtorAppService atorAppService, [FromBody] AtorRequest atorDTO) =>
        {
           return atorAppService.Adicionar(atorDTO);
        });
        app.MapPut("/v1/ator/upd/{id}",  ([FromServices]IAtorAppService atorAppService, [FromBody]AtorRequest atorDTO) =>
        {
            return atorAppService.Atualizar(atorDTO.Id, atorDTO);
        });
        app.MapGet("/v1/ator/{id}",  ([FromServices] IAtorAppService atorAppService, [FromRoute] int id) =>
        {
            return atorAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/ator/del/{id}",  ([FromServices] IAtorAppService atorAppService, [FromRoute] int id) =>
        {
            return atorAppService.ExcluirDTO(id);
        });

        //Exemplo de utilização do Dapper.
        app.MapGet("/v1/ator/dapper/{id}", ([FromRoute] int id) =>
        {
            AppDbContext context = new AppDbContext();
            AtorRepository repo = new AtorRepository(context);
            return repo.GetAtor2(id);
        });
        #endregion

    }
}
