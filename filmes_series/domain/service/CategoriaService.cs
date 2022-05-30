using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using filmes_series.domain.interfaces.services;

namespace filmes_series.domain.service
{
    public class CategoriaService:ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }
        public bool Adicionar(Categoria _categoria)
        {
            return _repository.Adicionar(_categoria);   
        }

        public bool Atualizar(int id, Categoria _categoria)
        {
            return _repository.Atualizar(id, _categoria);
        }

        public bool Excluir(int id)
        {
            return _repository.Excluir(id);
        }

        public Categoria ObterPorId(int id)
        {
            return _repository.GetById(id);
        }

        public List<Categoria> ObterTodos()
        {
            return _repository.FindAll();
        }
    public void Dispose()
    {
        _repository.Dispose();
        GC.SuppressFinalize(this);
    }
}
}
