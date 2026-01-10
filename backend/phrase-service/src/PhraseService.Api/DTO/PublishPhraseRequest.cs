namespace PhraseService.Api.DTO
{
    public class PublishPhraseRequest
    {
        public required string Text { get; set; }
        public required string UserId { get; set; }
        public required string Font { get; set; }
        public required int FontSize { get; set; }
        public required string Color { get; set; }
    }
}