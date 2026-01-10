namespace PhraseService.Api.DTO
{
    public record WallItem(
    string Text,
    string AuthorId,
    string Font,
    int FontSize,
    string Color
);
}