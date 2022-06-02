using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.service.request_response;

namespace filmes_series.mapper
{
    public static class AutoMapperConfig<T,X>
    {
        public static MapperConfiguration ConfigureMapper()
        {
            var config = new MapperConfiguration(cfg =>
                   cfg.CreateMap<T,X>().ReverseMap());
            return config;
        }
    }
}
