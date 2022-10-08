using Dapper;
using filmes_series._base.baserepository;
using filmes_series.data.context;
using filmes_series.domain.entity;
using filmes_series.domain.interfaces.repository;

namespace filmes_series.data.repository
{
    public class SerieRepository : BaseRepository<Serie>,ISerieRepository
    {
        private AppDbContext context;
        public SerieRepository(AppDbContext _context):base(_context)
        {
            context = _context;
        }

        public override Serie Adicionar(Serie _entity)
        {
            var categoria = context.Categorias.FirstOrDefault(c => c.Id == _entity.CategoriaId);
            var _elenco = new List<Ator>();
            if (_entity.ElencoSerie != null)
            {

                foreach (var item in _entity.ElencoSerie)
                {
                    _elenco.Add(context.Atores.FirstOrDefault(x => x.Id == item.Id));
                }
            }
            _entity.ElencoSerie = _elenco;
            _entity.Categoria = categoria;
            return base.Adicionar(_entity);
        }

    }
}
