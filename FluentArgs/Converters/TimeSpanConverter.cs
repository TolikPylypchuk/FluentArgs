using System;

namespace FluentArgs.Converters
{
    public class TimeSpanConverter : ArgumentConverter<TimeSpan>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid time span.";

        public TimeSpanConverter() : base(DefaultErrorMessage) { }

        protected override Result<TimeSpan> Parse(string arg)
            => TimeSpan.TryParse(arg, out TimeSpan value)
                ? Result.Success(value)
                : Result.Failure<TimeSpan>(this.ErrorMessage);
    }
}
