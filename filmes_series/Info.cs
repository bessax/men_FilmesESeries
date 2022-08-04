using Microsoft.OpenApi.Models;

namespace filmes_series
{
    internal class Info : OpenApiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }
}
