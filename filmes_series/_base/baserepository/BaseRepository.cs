using filmes_series.data.context;
using Microsoft.EntityFrameworkCore;

namespace filmes_series._base.baserepository
{
    public class BaseRepository<TEntity>:IBaseRepository<TEntity> where TEntity:class
    {
        private readonly DbContext _context;
        private DbSet<TEntity> dbset;

        public BaseRepository(DbContext context)
        {
            _context = context;
            dbset = _context.Set<TEntity>();
        }
        public bool Adicionar(TEntity _entity)
        {
            try
            {
                dbset.Add(_entity);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Atualizar(int id, TEntity _obj)
        {
            try { 

                var __obj = dbset.Find(id);
                if (__obj != null)
                {
                    return false;
                }
                    _context.Entry(_obj).State = EntityState.Modified;
                    _context.SaveChanges();
                    return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Excluir(int id)
        {
            var _obj = dbset.Find(id);

            try
            {
                if (_obj == null)
                {
                    return false;
                }
                dbset.Remove(_obj);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TEntity> FindAll()
        {
            try
            {
                return dbset.ToList();
            }
            catch
            {
                throw new Exception("Erro ao obter Lista.");
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                var _obj = dbset.Find(id);
                if (_obj == null)
                {
                    return null;
                }
                return _obj;
            }
            catch
            {
                throw new Exception($"Erro ao obter elemento com Id = {id}.");
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

    

      
    }
}
