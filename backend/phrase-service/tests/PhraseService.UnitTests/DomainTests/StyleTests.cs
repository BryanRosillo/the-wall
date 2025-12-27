using PhraseService.Domain.ValueObjects;

public class StyleTests
{
    [Fact]
    public void Create_style_with_valid_values()
    {
        var style = new Style("Arial", 10, "#0000FF");

        Assert.Equal("Arial", style.Font);
        Assert.Equal(10, style.FontSize);
        Assert.Equal("#0000FF", style.Color);
    }
    
}