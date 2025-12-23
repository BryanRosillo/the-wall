public class PhraseContext
{
    public string? AuthToken {get; set;}
    public PhraseRequest? Phrase { get; set; }
    public List<WallItem>? Wall {get; set;}
    public HttpClient? Client { get; set; }
    public HttpResponseMessage? Response { get; set; }
}