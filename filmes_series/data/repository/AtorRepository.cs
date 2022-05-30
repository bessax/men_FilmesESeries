using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class AtorRepository : IAtorRepository
    {
        private readonly AppDbContext _context;

        public AtorRepository()
        {
            _context = new AppDbContext();
        }
        public bool Adicionar(Ator _ator)
        {
            try
            {
                _context.Atores.Add(_ator);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Atualizar(int id, Ator _ator)
        {
            try
            {
                if (id != _ator.Id)
                {
                    return false;
                }
                _context.Entry(_ator).State = EntityState.Modified;
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
            var ator = _context.Atores.FirstOrDefault(p => p.Id == id);

            try
            {
                if (ator == null)
                {
                    return false;
                }
                _context.Atores.Remove(ator);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Ator> FindAll()
        {
            try
            {
                return _context.Atores.ToList();
            }
            catch
            {
                throw new Exception("Erro ao obter Atores");
            }
        }

        public Ator GetById(int id)
        {
            try
            {
                var ator = _context.Atores.FirstOrDefault(p => p.Id == id);
                if (ator == null)
                {
                    return null;
                }
                return ator;
            }
            catch
            {
                throw new Exception($"Erro ao obter Ator com Id = {id}.");
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
