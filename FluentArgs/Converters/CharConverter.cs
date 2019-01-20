using System;

namespace FluentArgs.Converters
{
    public class CharConverter : ArgumentConverter<char>
    {
        public static readonly string DefaultErrorMessage = "The argument must contain a single character.";

        public CharConverter() : base(DefaultErrorMessage) { }

        protected override Result<char> Parse(string arg)
            => Char.TryParse(arg, out char value)
                ? Result.Success(value)
                : Result.Failure<char>(this.ErrorMessage);
    }
}
