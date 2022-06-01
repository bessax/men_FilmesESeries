using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class AtorRepository : BaseRepository<Ator>,IAtorRepository
    {
        private readonly AppDbContext _context;

        public AtorRepository()
        {
            _context = new AppDbContext();
        }
        
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
