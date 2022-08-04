using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.interfaces.repository;
using filmes_series.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.Data.Repository
{
    public class UserAppRepository : BaseRepository<UserApp>, IUserAppRepository
    {
        private AppDbContext context;
        public UserAppRepository(AppDbContext _context) : base(_context)
        {
            context = _context; 
        }

        public UserApp ObterPorEmail(string email)
        {
            return context.UserApps.Where(x => x.Email.Equals(email)).SingleOrDefault();
        }
    }
}
