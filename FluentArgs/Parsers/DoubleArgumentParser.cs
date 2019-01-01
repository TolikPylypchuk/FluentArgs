using System;

namespace FluentArgs.Parsers
{
    public class DoubleArgumentParser : ArgumentParser<double>
    {
        protected override ParseResult<double> Parse(string arg)
            => Double.TryParse(arg, out double value)
                ? ParseResult.Success(value)
                : ParseResult.Failure<double>();
    }
}
