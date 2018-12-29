using System;

namespace FluentArgs.Parsers
{
    public class DoubleArgParser : ArgParser<double>
    {
        protected override ParseResult<double> Parse(string arg)
            => Double.TryParse(arg, out double value)
                ? ParseResult.Success(value)
                : ParseResult.Failure<double>();
    }
}
