using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEP
{
    public static void AddEndpoints(this WebApplication app)
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

        #region Categoria
        string categoria = "categoria";
        app.MapGet($"/v1/{categoria}/todos", ([FromServices] ICategoriaAppService categoriaAppService) =>
        {
            return categoriaAppService.ObterTodosDTO();
        });
        app.MapPost($"/v1/{categoria}/add", ([FromServices] ICategoriaAppService categoriaAppService, [FromBody] CategoriaRequest obj) =>
        {
            return categoriaAppService.Adicionar(obj);
        });
        app.MapPut($"/v1/{categoria}/upd", ([FromServices] ICategoriaAppService categoriaAppService, [FromBody] CategoriaRequest obj) =>
        {
            return categoriaAppService.Atualizar(obj.Id, obj);
        });
        app.MapGet("/v1/categoria/{id}", ([FromServices] ICategoriaAppService categoriaAppService, [FromRoute] int id) =>
        {
            return categoriaAppService.ObterPorIdDTO(id);
        });
        app.MapGet("/v1/categoria/del/{id}", ([FromServices] ICategoriaAppService categoriaAppService, [FromRoute] int id) =>
        {
            return categoriaAppService.ExcluirDTO(id);
        });
        #endregion

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
