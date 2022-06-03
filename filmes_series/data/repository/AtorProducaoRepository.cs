using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class AtorProducaoRepository : BaseRepository<AtorProducao>, IAtorProducaoRepository
    {
        private AppDbContext context;
        public AtorProducaoRepository(AppDbContext _context) : base(_context)
        {
            context = _context;
        }

        public List<AtorProducao> ObterTodos()
        {
            return context.AtorProducao.Include(x => x.Producoes)
                                       .Include(y=> y.Elenco).ToList();

        }
    }
}
