using Microsoft.Playwright;

namespace Free_PDF_Generator.Utilities;

internal static class PDFGenerator
{
    public static async Task GeneratePDFAsync(string html)
    {
        using var playWright = await Playwright.CreateAsync();
        var browser = await playWright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = true
        });

        var page = await browser.NewPageAsync();
        await page.SetContentAsync(html);

        await page.PdfAsync(new PagePdfOptions
        {
            Path = "./output.pdf",
            Format = "A4"
        });

        await page.CloseAsync();
    }
}
