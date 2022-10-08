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
    public class FilmeRepository : BaseRepository<Filme>, IFilmeRepository
    {
        private AppDbContext context;
        public FilmeRepository(AppDbContext _context):base(_context)
        {
            context = _context;
        }

        public override Filme Adicionar(Filme _entity)
        {
            var categoria = context.Categorias.FirstOrDefault(c => c.Id == _entity.CategoriaId);
            var _elenco = new List<Ator>();
            if (_entity.ElencoFilme!=null)
            {
                
                foreach (var item in _entity.ElencoFilme)
                {
                    _elenco.Add(context.Atores.FirstOrDefault(x => x.Id == item.Id));
                }
            }
            _entity.ElencoFilme = _elenco;
            _entity.Categoria = categoria;
            return base.Adicionar(_entity);
        }

        public override Filme Atualizar(int id, Filme _obj)
        {
            try
            {
                var __obj = context.Filmes.Find(id);
                context.Entry(__obj).State = EntityState.Detached;
                var categoria = context.Categorias.FirstOrDefault(c => c.Id == _obj.CategoriaId);
                var _elenco = new List<Ator>();
                
                if (_obj.ElencoFilme != null)
                {

                    foreach (var item in _obj.ElencoFilme)
                    {
                        _elenco.Add(context.Atores.FirstOrDefault(x => x.Id == item.Id));
                    }
                }
                _obj.ElencoFilme = _elenco;
                _obj.Categoria = categoria;
                context.Entry(_obj).State = EntityState.Modified;  
                context.SaveChanges();
                return _obj;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar." + ex.Message);
            }
            

        }

    }
}
