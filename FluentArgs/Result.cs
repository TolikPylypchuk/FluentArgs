namespace FluentArgs
{
    public sealed class Result<T>
    {
        public T Value { get; }
        public bool IsSuccess { get; }

        internal Result(T value, bool isSuccess)
        {
            this.Value = value;
            this.IsSuccess = isSuccess;
        }
    }

    public static class Result
    {
        public static Result<T> Success<T>(T value)
            => new Result<T>(value, true);

        public static Result<T> Failure<T>()
            => new Result<T>(default, false);
    }
}
