namespace FlipIt.API.Exceptions
{
    public class EFMissingEntryException : EntityFrameworkException
    {
        public EFMissingEntryException(string? message, Exception? inner = null) : base(message, inner)
        {

        }
    }
}
