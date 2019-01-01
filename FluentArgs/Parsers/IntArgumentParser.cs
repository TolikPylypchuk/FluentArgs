using System;

namespace FluentArgs.Parsers
{
    public sealed class IntArgumentParser : ArgumentParser<int>
    {
        protected override ParseResult<int> Parse(string arg)
            => Int32.TryParse(arg, out int value)
                ? ParseResult.Success(value)
                : ParseResult.Failure<int>();
    }
}
