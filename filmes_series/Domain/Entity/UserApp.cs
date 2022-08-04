using System.ComponentModel.DataAnnotations;

namespace filmes_series.Domain.Entity
{
    public class UserApp
    {    
        public int Id { get; set; }

        [StringLength(255)]
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(255)]
        public string Senha { get; set; }
    }
}
