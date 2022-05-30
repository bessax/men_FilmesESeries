using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;
using Microsoft.EntityFrameworkCore;

namespace filmes_series.data.repository
{
    public class ProducoesRepository : IProducaoRepository
    {
        private readonly AppDbContext _context;

        public ProducoesRepository()
        {
            _context = new AppDbContext();
        }
        public bool Adicionar(Producao _obj)
        {
            try
            {
                _context.Producoes.Add(_obj);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Atualizar(int id, Producao _obj)
        {
            try
            {
                if (id != _obj.Id)
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
            var _obj = _context.Producoes.FirstOrDefault(p => p.Id == id);

            try
            {
                if (_obj == null)
                {
                    return false;
                }
                _context.Producoes.Remove(_obj);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Producao> FindAll()
        {
            try
            {
                return _context.Producoes.ToList();
            }
            catch
            {
                throw new Exception("Erro ao obter Produções");
            }
        }

        public Producao GetById(int id)
        {
            try
            {
                var ator = _context.Producoes.FirstOrDefault(p => p.Id == id);
                if (ator == null)
                {
                    return null;
                }
                return ator;
            }
            catch
            {
                throw new Exception($"Erro ao obter Produção com Id = {id}.");
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
