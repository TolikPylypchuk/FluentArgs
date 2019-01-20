using System;

namespace FluentArgs.Converters
{
    public class DateTimeConverter : ArgumentConverter<DateTime>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid date-time value.";

        public DateTimeConverter() : base(DefaultErrorMessage) { }

        protected override Result<DateTime> Parse(string arg)
            => DateTime.TryParse(arg, out DateTime value)
                ? Result.Success(value)
                : Result.Failure<DateTime>(this.ErrorMessage);
    }
}
