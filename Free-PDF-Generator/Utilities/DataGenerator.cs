using Bogus;
using Free_PDF_Generator.Models;

namespace Free_PDF_Generator.Utilities;

internal class DataGenerator
{
    public static PDF Generate_PDF_Data()
    {
        var fakeData = new Faker();
        return new PDF
        {
            Name = fakeData.System.FileName(),
            Number = fakeData.Random.Number(1000, 9999).ToString(),
            Date = fakeData.Date.SoonDateOnly(0).AddMonths(1)
        };
    }
}
