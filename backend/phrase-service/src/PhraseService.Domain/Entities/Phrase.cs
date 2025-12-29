using PhraseService.Domain.Exceptions;
using PhraseService.Domain.ValueObjects;

namespace PhraseService.Domain.Entities
{
    public class Phrase
    {
        public string Text { get; private set; }
        public string AuthorId {get; private set;}
        public Style Style { get; private set; }

        public Phrase(string text, string authorId, Style style)
        {
            string textToAdd = text.Trim();
            string author = authorId.Trim();
            if (textToAdd == "")
            {
                throw new NullTextException();
            }
            if (textToAdd.Length > 500)
            {
                throw new TextLongException();
            }
            if(author == "")
            {
                throw new NullAuthorIdException();
            }
            

            Style = style;
            Text = textToAdd;
        }

    }
}