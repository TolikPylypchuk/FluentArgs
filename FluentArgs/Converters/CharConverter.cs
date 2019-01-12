using System;

namespace FluentArgs.Converters
{
    public class CharConverter : ArgumentConverter<char>
    {
        protected override Result<char> Parse(string arg)
            => Char.TryParse(arg, out char value)
                ? Result.Success(value)
                : Result.Failure<char>();
    }
}
