namespace PhraseService.Domain.Exceptions
{
    public class NullTextException : DomainException
    {
        public NullTextException() : base("The text cannot be null or empty.")
        {
        }
    }
}