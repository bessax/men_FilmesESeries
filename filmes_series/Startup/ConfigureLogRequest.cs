using Serilog;
using Serilog.Events;

namespace filmes_series.Startup
{
    public static class ConfigureLogRequest
    {
        public static void AddSerialogAPI(this WebApplicationBuilder builder)
        {
            string _data = DateTime.Now.ToString("yyyy-MM-dd_HH");
            string path = builder.Configuration.GetSection("LoggerBasePath").Value;
            string template = builder.Configuration.GetSection("LoggerBasePath").Value;

            Log.Logger = new LoggerConfiguration()
                          .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Information)
                          .Enrich.FromLogContext()
                          .WriteTo.Console()
                          .CreateLogger();

            builder.Host.UseSerilog(Log.Logger);
        }
    }
}
