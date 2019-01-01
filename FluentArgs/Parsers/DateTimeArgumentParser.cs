using System;

namespace FluentArgs.Parsers
{
    public class DateTimeArgumentParser : ArgumentParser<DateTime>
    {
        protected override ParseResult<DateTime> Parse(string arg)
            => DateTime.TryParse(arg, out DateTime value)
                ? ParseResult.Success(value)
                : ParseResult.Failure<DateTime>();
    }
}
