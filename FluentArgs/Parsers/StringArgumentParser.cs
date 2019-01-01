namespace FluentArgs.Parsers
{
    public class StringArgumentParser : ArgumentParser<string>
    {
        protected override ParseResult<string> Parse(string arg)
            => ParseResult.Success(arg);
    }
}
