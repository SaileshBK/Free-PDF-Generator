using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Free_PDF_Generator.Extensions;

internal static class ServiceCollectionExtension
{
    public static (ServiceProvider, ILoggerFactory) AddRequiredServices(this IServiceCollection services)
    {
        services.AddLogging();
        var serviceProvider = services.BuildServiceProvider();
        var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
        return (serviceProvider, loggerFactory);
    }
}
