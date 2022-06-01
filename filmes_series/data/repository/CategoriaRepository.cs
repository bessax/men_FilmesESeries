using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class CategoriaRepository: BaseRepository<Categoria>,ICategoriaRepository
    {
        
        public CategoriaRepository(AppDbContext _context):base(_context)
        {
        }    
    
    }
}
