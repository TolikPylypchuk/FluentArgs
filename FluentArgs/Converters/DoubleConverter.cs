using System;

namespace FluentArgs.Converters
{
    public class DoubleConverter : ArgumentConverter<double>
    {
        protected override Result<double> Parse(string arg)
            => Double.TryParse(arg, out double value)
                ? Result.Success(value)
                : Result.Failure<double>();
    }
}
