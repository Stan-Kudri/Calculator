namespace Calculator.Domain
{
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
        }

        public ApplicationException(string? message) : base(message)
        {
        }

        public ApplicationException(string message, Exception exception) : base(message)
        {
        }
    }
}
