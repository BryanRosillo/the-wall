namespace PhraseService.Domain.Exceptions
{
    public class NullAuthorIdException : Exception
    {
        public NullAuthorIdException() : base("The author ID cannot be null or empty.")
        {
        }
    }
}