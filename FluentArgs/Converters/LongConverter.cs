using System;

namespace FluentArgs.Converters
{
    public class LongConverter : ArgumentConverter<long>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid integer number.";

        public LongConverter() : base(DefaultErrorMessage) { }

        protected override Result<long> Parse(string arg)
            => Int64.TryParse(arg, out long value)
                ? Result.Success(value)
                : Result.Failure<long>(this.ErrorMessage);
    }
}
