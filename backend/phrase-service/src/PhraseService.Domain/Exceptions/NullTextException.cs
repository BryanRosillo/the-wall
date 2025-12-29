namespace PhraseService.Domain.Exceptions
{
    public class NullTextException : Exception
    {
        public NullTextException() : base("The text cannot be null or empty.")
        {
        }
    }
}