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
    public class AtorRepository : BaseRepository<Ator>,IAtorRepository
    {
        private AppDbContext context;
        public AtorRepository(AppDbContext _context):base(_context)
        {
            context = _context;
        }
           
        public Ator GetAtor2(int id)
        {
            // implementando uma consulta com dapper
            var conn = context.Database.GetConnectionString();
            Ator ator = null;
            var sql = "SELECT * FROM atores WHERE Id=@Id";
            using (IDbConnection db = new MySqlConnection(conn))
            {
                ator = db.Query<Ator>(sql, new {id}).SingleOrDefault();
            }

            return ator;
        }

    }
}
