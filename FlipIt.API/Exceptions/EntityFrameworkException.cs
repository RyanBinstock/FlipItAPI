namespace FlipIt.API.Exceptions
{
    public class EntityFrameworkException : DatabaseException
    {
        public EntityFrameworkException(string? message, Exception? inner = null) : base(message, inner)
        {

        }
    }
}
