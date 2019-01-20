using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentArgs
{
    public sealed class Result<T>
    {
        public T Value { get; }
        public bool IsSuccess { get; }
        public IEnumerable<string> ErrorMessages { get; }

        internal Result(T value, bool isSuccess, IEnumerable<string> errorMessages)
        {
            this.Value = value;
            this.IsSuccess = isSuccess;
            this.ErrorMessages = errorMessages;
        }
    }

    public static class Result
    {
        public static Result<T> Success<T>(T value)
            => new Result<T>(value, true, null);

        public static Result<T> Failure<T>(string errorMessage)
            => new Result<T>(default, false, new[] { errorMessage ?? throw new ArgumentNullException(nameof(errorMessage)) });
        
        public static Result<T> Failure<T>(IEnumerable<string> errorMessages)
            => errorMessages != null
                ? errorMessages.Count() != 0
                    ? new Result<T>(default, false, errorMessages)
                    : throw new ArgumentOutOfRangeException(nameof(errorMessages))
                : throw new ArgumentNullException(nameof(errorMessages));
    }
}
