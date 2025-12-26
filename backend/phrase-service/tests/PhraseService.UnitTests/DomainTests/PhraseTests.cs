public class PhraseTests
{
    [Fact]
    public void Create_phrase_with_valid_text()
    {
        var phrase = new Phrase("Hello, world!");
        Assert.Equal("Hello, world!", phrase.Text);
    }

    [Fact]
    public void Create_phrase_with_empty_text_throws_exception()
    {
        Assert.Throws<NullTextException>(() => new Phrase(""));
    }

    [Fact]
    public void Create_phrase_with_501_characters_text_throws_exception()
    {
        var longText = new string('a', 501);
        Assert.Throws<TextLongException>(() => new Phrase(longText));
    }
}