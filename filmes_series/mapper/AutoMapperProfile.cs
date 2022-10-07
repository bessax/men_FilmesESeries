using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.Domain.Entity;
using filmes_series.service.request_response;
using filmes_series.Service.Request_response;

namespace filmes_series.mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ator,AtorRequest>();
            CreateMap<Categoria,CategoriaRequest>();

            CreateMap<Filme, FilmeRequest>();
            CreateMap<Serie, SerieRequest>();

            CreateMap<UserApp, UserAppRequest>();
       
            CreateMap<Ator, AtorResponse>();            
            CreateMap<Categoria, CategoriaResponse>();            
            
            CreateMap<UserApp, UserAppResponse>();

            CreateMap<AtorRequest,Ator>();
            CreateMap<CategoriaRequest,Categoria>();

            CreateMap<FilmeRequest, Filme>();
            CreateMap<SerieRequest, Serie>();

            CreateMap<FilmeResponse, Filme>();
            CreateMap<SerieResponse, Serie>();

            CreateMap<UserAppResponse,UserApp > ();

            CreateMap<AtorResponse, Ator>();
            CreateMap<CategoriaResponse, Categoria>();
                    
            CreateMap<UserAppRequest, UserApp>();
        }
    }
}
