using AutoMapper;
using filmes_series.domain.entity;
using filmes_series.mapper;
using filmes_series.service.request_response;
using filmes_seriesTests.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace filmes_seriesTests.Mapper
{
    public class MapperTest
    {
        private static IMapper _mapper;

        public MapperTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public void AtorRequestResponseTest()
        {
            var request = new AtorBuilder().BuildRequest();

            var _ator = _mapper.Map<Ator>(request);

            Assert.Equal(_ator.Id, request.Id);
        }

        [Fact]
        public void AtorResponseRequestTest()
        {

            var _ator = new AtorBuilder().Build();
            var response = _mapper.Map<AtorResponse>(_ator); 

            Assert.Equal(_ator.Id, response.Id);
        }
    }
}
