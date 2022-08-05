using filmes_series.data.context;
using filmes_series.data.repository;
using filmes_series.Domain.Entity;
using filmes_series.Security;
using filmes_series.service.interfaces;
using filmes_series.service.request_response;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace filmes_series.startup;

public static class ConfigureEPAAuth
{
    public static void AddEndpointsAuth(this WebApplication app)
    {
        #region Auth       
        
        app.MapPost("/v1/auth/add", ([FromServices] IUserAppAppService userAppAppService, [FromBody] UserApp model) =>
        {
            // Decifra a senha  e atualiza o objeto.
            string salto = ConfigSeg.Secret + model.Senha;
            string senha = Cripto.sha256encrypt(salto);
            model.Senha = senha.ToLower();

            UserAppResponse userAux = userAppAppService.ObterPorEmail(model.Email);

            if (userAux == null)
            {
                
                //Retornar mensagem
            }

            UserApp user = new UserApp();
            user.UserName = userAux.UserName;
            user.Senha = userAux.Senha;
         
            var token = TokenService.GenerateToken(user);
            user.Senha = "";
            return new
            {
                idUser = userAux.Id,
                token = token
            };


        });
        
        #endregion

    }
}
