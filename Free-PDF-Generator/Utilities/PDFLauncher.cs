using Microsoft.Playwright;

namespace Free_PDF_Generator.Utilities;

internal static class PDFLauncher
{
    public static async Task LaunchAsync(string htmlString)
    {
        try
        {
            await PDFGenerator.GeneratePDFAsync(htmlString);
        }
        catch (PlaywrightException)
        {
            Microsoft.Playwright.Program.Main(["install"]);
            await LaunchAsync(htmlString);
        }
    }
}
