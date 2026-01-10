namespace PhraseService.Domain.Exceptions
{
    public class TextLongException : DomainException
    {
        public TextLongException() : base("The text exceeds the maximum allowed length of 500 characters.")
        {
        }
    }
}