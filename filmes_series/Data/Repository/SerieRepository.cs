using Dapper;
using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System.Data;

namespace filmes_series.data.repository
{
    public class FilmeRepository : BaseRepository<Filme>,IFilmeRepository
    {
        private AppDbContext context;
        public FilmeRepository(AppDbContext _context):base(_context)
        {
            context = _context;
        }          
     

    }
}
