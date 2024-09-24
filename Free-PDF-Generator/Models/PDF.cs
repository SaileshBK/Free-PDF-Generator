namespace Free_PDF_Generator.Models;

public record PDF(
    string Name,
    string? Number,
    DateOnly Date,
    string? Title,
    string? Author,
    string? Content,
    int PageCount,
    DateTime CreatedDate);
