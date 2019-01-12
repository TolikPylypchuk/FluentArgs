using System;

namespace FluentArgs.Converters
{
    public class LongConverter : ArgumentConverter<long>
    {
        protected override Result<long> Parse(string arg)
            => Int64.TryParse(arg, out long value)
                ? Result.Success(value)
                : Result.Failure<long>();
    }
}
