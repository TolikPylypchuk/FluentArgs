using System;

namespace FluentArgs.Converters
{
    public class DecimalConverter : ArgumentConverter<decimal>
    {
        protected override Result<decimal> Parse(string arg)
            => Decimal.TryParse(arg, out decimal value)
                ? Result.Success(value)
                : Result.Failure<decimal>();
    }
}
