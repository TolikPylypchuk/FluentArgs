using System;

namespace FluentArgs.Converters
{
    public sealed class IntConverter : ArgumentConverter<int>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid integer number.";

        public IntConverter() : base(DefaultErrorMessage) { }

        protected override Result<int> Parse(string arg)
            => Int32.TryParse(arg, out int value)
                ? Result.Success(value)
                : Result.Failure<int>(this.ErrorMessage);
    }
}
