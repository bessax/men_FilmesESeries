using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class AtorRepository : BaseRepository<Ator>,IAtorRepository
    {
        private AppDbContext context;
        public AtorRepository(AppDbContext _context):base(_context)
        {
            context = _context;
         }

        public List<Ator> ObterTodos()
        {
            return context.Atores.Include(x=>x.AtorProducao)
                                    .ThenInclude(y=>y.Producoes).ToList();
                                 
        }
    }
}
