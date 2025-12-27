using PhraseService.Domain.Exceptions;
using PhraseService.Domain.ValueObjects;

namespace PhraseService.Domain.Entities
{
    public class Phrase
    {
        public string Text { get; private set; }
        public Style Style { get; private set; }

        public Phrase(string text, Style style)
        {
            string textToAdd = text.Trim();
            if (textToAdd == "")
            {
                throw new NullTextException();
            }
            if (textToAdd.Length > 500)
            {
                throw new TextLongException();
            }
            Style = style;
            Text = textToAdd;
        }

    }
}