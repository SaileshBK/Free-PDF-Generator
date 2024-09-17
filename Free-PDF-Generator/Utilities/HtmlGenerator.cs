using Free_PDF_Generator.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Free_PDF_Generator.Utilities;

internal static class HtmlGenerator
{
    public static async Task<string> GenerateHTMLAsync(ServiceProvider serviceProvider, ILoggerFactory loggerFactory)
    {
        await using var htmRenderer = new HtmlRenderer(serviceProvider, loggerFactory);
        var pdfData = DataGenerator.Generate_PDF_Data();
        return await htmRenderer.Dispatcher.InvokeAsync(async () =>
        {
            var dictionary = new Dictionary<string, object?>
            {
                { "pdf", pdfData }
            };

            var parameter = ParameterView.FromDictionary(dictionary);
            var output = await htmRenderer.RenderComponentAsync<PDF>(parameter);
            return output.ToHtmlString();
        });
    }
}
