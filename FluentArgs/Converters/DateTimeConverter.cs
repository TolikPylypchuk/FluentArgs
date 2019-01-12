using System;

namespace FluentArgs.Converters
{
    public class DateTimeConverter : ArgumentConverter<DateTime>
    {
        protected override Result<DateTime> Parse(string arg)
            => DateTime.TryParse(arg, out DateTime value)
                ? Result.Success(value)
                : Result.Failure<DateTime>();
    }
}
