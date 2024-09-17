using Free_PDF_Generator.Extensions;
using Free_PDF_Generator.Utilities;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static async Task Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        var (ServiceProvider, LoggerFactory) = services.AddRequiredServices();
        var htmlString = await HtmlGenerator.GenerateHTMLAsync(ServiceProvider, LoggerFactory);
        await PDFLauncher.LaunchAsync(htmlString);
    }
}