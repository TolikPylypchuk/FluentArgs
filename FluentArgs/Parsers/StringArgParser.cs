namespace FluentArgs.Parsers
{
    public class StringArgParser : ArgParser<string>
    {
        protected override ParseResult<string> Parse(string arg)
            => ParseResult.Success(arg);
    }
}
