using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class CategoriaRepository: BaseRepository<Categoria>,ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository()
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
