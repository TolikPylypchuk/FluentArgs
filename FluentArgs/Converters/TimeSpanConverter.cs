using System;

namespace FluentArgs.Converters
{
    public class TimeSpanConverter : ArgumentConverter<TimeSpan>
    {
        protected override Result<TimeSpan> Parse(string arg)
            => TimeSpan.TryParse(arg, out TimeSpan value)
                ? Result.Success(value)
                : Result.Failure<TimeSpan>();
    }
}
