using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPCategoria
{
    public static void AddEndpointsCategoria(this WebApplication app)
    {
       
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

    }
}
