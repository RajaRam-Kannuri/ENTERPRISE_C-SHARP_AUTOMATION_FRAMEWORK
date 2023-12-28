namespace SoftAssertion
{
    public class FailedAssert
    {
        public string Message { get; }

        public FailedAssert(string message)
        {
            Message = message;
        }

    }
}
