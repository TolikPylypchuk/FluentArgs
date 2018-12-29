namespace FluentArgs.Parsers
{
    public sealed class ParseResult<T>
    {
        public T Value { get; }
        public bool IsSuccess { get; }

        internal ParseResult(T value, bool isSuccess)
        {
            this.Value = value;
            this.IsSuccess = isSuccess;
        }
    }

    internal static class ParseResult
    {
        internal static ParseResult<T> Success<T>(T value)
            => new ParseResult<T>(value, true);

        internal static ParseResult<T> Failure<T>()
            => new ParseResult<T>(default, false);
    }
}
