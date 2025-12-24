public class PhraseTests
{
    [Fact]
    public void Create_phrase_with_valid_text()
    {
        var phrase = new Phrase("Hello, world!");
        Assert.Equal("Hello, world!", phrase.Text);
    }
}