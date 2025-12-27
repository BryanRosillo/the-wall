using PhraseService.Domain.Entities;
using PhraseService.Domain.ValueObjects;
using PhraseService.Domain.Exceptions;

public class PhraseTests
{
    [Fact]
    public void Create_phrase_with_valid_text_and_style()
    {
        var style = new Style("Arial", 10, "#0000FF");
        var phrase = new Phrase("Hello, world!", style);

        Assert.Equal("Hello, world!", phrase.Text);
        Assert.Equal(style, phrase.Style);
    }

    [Fact]
    public void Create_phrase_with_empty_text_throws_exception()
    {
        var style = new Style("Arial", 10, "#0000FF");

        Assert.Throws<NullTextException>(() => new Phrase("", style));
    }

    [Fact]
    public void Create_phrase_with_501_characters_text_throws_exception()
    {
        var longText = new string('a', 501);
        var style = new Style("Arial", 10, "#0000FF");

        Assert.Throws<TextLongException>(() => new Phrase(longText, style));
    }
}