using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebService.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
    }
}