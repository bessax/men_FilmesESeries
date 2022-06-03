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
            CreateMap<AtorProducao, AtorProducaoRequest>();

            CreateMap<Ator, AtorResponse>();
            CreateMap<Categoria, CategoriaResponse>();
            CreateMap<Producao, ProducaoResponse>();
            CreateMap<AtorProducao, AtorProducaoResponse>();

            CreateMap<AtorRequest,Ator>();
            CreateMap<CategoriaRequest,Categoria>();
            CreateMap<ProducaoRequest,Producao>();
            CreateMap<AtorProducaoRequest, AtorProducao>();

            CreateMap<AtorResponse, Ator>();
            CreateMap<CategoriaResponse, Categoria>();
            CreateMap<ProducaoResponse, Producao>();
            CreateMap<AtorProducaoResponse, AtorProducao>();
        }
    }
}
