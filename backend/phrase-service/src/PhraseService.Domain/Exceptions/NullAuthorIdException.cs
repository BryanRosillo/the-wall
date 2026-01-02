namespace PhraseService.Domain.Exceptions
{
    public class NullAuthorIdException : DomainException
    {
        public NullAuthorIdException() : base("The author ID cannot be null or empty.")
        {
        }
    }
}