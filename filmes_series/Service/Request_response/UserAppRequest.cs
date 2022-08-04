using System.Text.Json.Serialization;

namespace filmes_series.service.request_response
{
    public class UserAppRequest
    {
        public int Id { get; set; }      
        public string UserName { get; set; }
        public string Email { get; set; }     
        public string Senha { get; set; }

    }
}
