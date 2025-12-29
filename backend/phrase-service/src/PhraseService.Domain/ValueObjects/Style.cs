namespace PhraseService.Domain.ValueObjects
{
    public class Style
    {
        public string Font {get; private set;}
        public int FontSize {get; private set;}

        public string Color {get; private set;}

        public Style(string font, int fontSize, string color)
        {
            Font = font;
            FontSize = fontSize;
            Color = color;
        }
    }
}