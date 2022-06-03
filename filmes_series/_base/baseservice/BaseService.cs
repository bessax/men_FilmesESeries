using filmes_series._base.baserepository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series._base.baseservice
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
       
        private readonly DbContext _context;
        private IBaseRepository<TEntity> repository;
        public BaseService(IBaseRepository<TEntity> _repository)
        {
            repository = _repository;
        }
        public virtual TEntity Adicionar(TEntity _obj)
        {
            return repository.Adicionar(_obj);
        }

        public virtual TEntity Atualizar(int id, TEntity _obj)
        {
            return repository.Atualizar(id, _obj);
        }

        public virtual TEntity Excluir(int id)
        {
            return repository.Excluir(id);
        }

        public virtual TEntity ObterPorId(int id)
        {
            return repository.GetById(id);
        }

        public virtual List<TEntity> ObterTodos()
        {
            return repository.FindAll();
        }
    }
}
