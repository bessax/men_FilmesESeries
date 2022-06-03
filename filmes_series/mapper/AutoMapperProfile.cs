using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.service.request_response;

namespace filmes_series.mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ator,AtorRequest>();
            CreateMap<Categoria,CategoriaRequest>();
            CreateMap<Producao,ProducaoRequest>();

            CreateMap<AtorRequest,Ator>();
            CreateMap<CategoriaRequest,Categoria>();
            CreateMap<ProducaoRequest,Producao>();
        }
    }
}
