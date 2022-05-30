using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class CategoriaRepository:ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository()
        {
            _context = new AppDbContext();
        }
        public bool Adicionar(Categoria _categoria)
        {
            try
            {
                _context.Categorias.Add(_categoria);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Atualizar(int id, Categoria _categoria)
        {
            try
            {
                if (id != _categoria.Id)
                {
                    return false;
                }
                _context.Entry(_categoria).State = EntityState.Modified;
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
            var categoria = _context.Categorias.FirstOrDefault(p => p.Id == id);

            try
            {
                if (categoria == null)
                {
                    return false;
                }
                _context.Categorias.Remove(categoria);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Categoria> FindAll()
        {
            try
            {
                return _context.Categorias.ToList();
            }
            catch
            {
                throw new Exception("Erro ao obter Categorias");
            }
        }

        public Categoria GetById(int id)
        {
            try
            {
                var ator = _context.Categorias.FirstOrDefault(p => p.Id == id);
                if (ator == null)
                {
                    return null;
                }
                return ator;
            }
            catch
            {
                throw new Exception($"Erro ao obter Categoria com Id = {id}.");
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
