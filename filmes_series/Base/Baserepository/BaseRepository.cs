using filmes_series.data.context;
using filmes_series.filmes_series.Base.Baserepository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series._base.baserepository
{
    public class BaseRepository<T>:IBaseRepository<T> where T:class
    {
        private readonly DbContext _context;
        private DbSet<T> dbset;

        public BaseRepository(DbContext context)
        {
            _context = context;
            dbset = _context.Set<T>();
        }
        public virtual T Adicionar(T _entity)
        {
            try
            {
                _context.Add(_entity);
                _context.SaveChanges();

                return _entity;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao adicionar."+ ex.Message);
            }
        }

        public virtual T Atualizar(int id, T _obj)
        {
            try { 

                var __obj = dbset.Find(id);
                if (__obj == null)
                {
                    throw new Exception("Não encontrado.");
                }
                _context.Entry(__obj).State = EntityState.Detached;
                _context.Entry(_obj).State = EntityState.Modified;
                _context.SaveChanges();
               return _obj;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar." + ex.Message);
            }
        }

        public virtual T Excluir(int id)
        {
            var _obj = dbset.Find(id);

            try
            {
                if (_obj == null)
                {
                    throw new Exception("Não encontrado.");
                }
                dbset.Remove(_obj);
                _context.SaveChanges();
                return _obj;
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao Excluir.{ex.Message}");
            }
        }

        public virtual List<T> FindAll()
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

        public virtual T GetById(int id)
        {
            try
            {
                var _obj = dbset.Find(id);
                if (_obj == null)
                {
                    throw new Exception("Não encontrado.");
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
